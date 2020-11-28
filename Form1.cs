using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace JsonComparer
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker backgroundWorker;

        public Form1()
        {
            InitializeComponent();
            tbPath1.Text = ReadSetting("PathToJson1");
            tbPath2.Text = ReadSetting("PathToJson2");

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += Worker_DoWork;
            backgroundWorker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var expectedJson = File.ReadAllText(tbPath1.Text);
            var actualJson = File.ReadAllText(tbPath2.Text);

            var currentJson = JObject.Parse(expectedJson);
            var modelJson = JObject.Parse(actualJson);

            e.Result = FindDiff(currentJson, modelJson);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is null)
                return;

            var form = new Form2
            {
                JsonName = $@"{Path.GetFileName(tbPath1.Text)}_{Path.GetFileName(tbPath2.Text)}",
                JsonText = e.Result.ToString()
            };
            form.Show();
            form.ShowJson();

            pb.Visible = false;
        }

        private static string ReadSetting(string key)
        {
            var result = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        private static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnJson1_Click(object sender, EventArgs e)
        {
            tbPath1.Text = ChoseFile(tbPath1.Text);
            AddUpdateAppSettings("PathToJson1", tbPath1.Text);
        }

        private void btnJson2_Click(object sender, EventArgs e)
        {
            tbPath2.Text = ChoseFile(tbPath2.Text);
            AddUpdateAppSettings("PathToJson2", tbPath2.Text);
        }

        private string ChoseFile(string path)
        {
            using var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = path == string.Empty
                    ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    : Path.GetDirectoryName(tbPath1.Text),
                Filter = "(*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            return path;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            pb.Visible = true;
            backgroundWorker.RunWorkerAsync();
        }

        private static JObject FindDiff(JToken currentJson, JToken modelJson)
        {
            var diff = new JObject();
            if (JToken.DeepEquals(currentJson, modelJson)) return diff;

            switch (currentJson.Type)
            {
                case JTokenType.Object:
                {
                    var model = modelJson as JObject;
                    if (currentJson is JObject current)
                    {
                        if (model != null)
                        {
                            var addedKeys = current.Properties().Select(c => c.Name)
                                .Except(model.Properties().Select(c => c.Name));
                            var removedKeys = model.Properties().Select(c => c.Name)
                                .Except(current.Properties().Select(c => c.Name));
                            var unchangedKeys = current.Properties()
                                .Where(c => JToken.DeepEquals(c.Value, modelJson[c.Name]))
                                .Select(c => c.Name);
                            var enumerable = addedKeys.ToList();
                            foreach (var k in enumerable)
                            {
                                diff[k] = new JObject
                                {
                                    ["+"] = currentJson[k]
                                };
                            }

                            foreach (var k in removedKeys)
                            {
                                diff[k] = new JObject
                                {
                                    ["-"] = modelJson[k]
                                };
                            }

                            var potentiallyModifiedKeys =
                                current.Properties().Select(c => c.Name).Except(enumerable).Except(unchangedKeys);
                            foreach (var k in potentiallyModifiedKeys)
                            {
                                var foundDiff = FindDiff(current[k], model[k]);
                                if (foundDiff.HasValues) diff[k] = foundDiff;
                            }
                        }
                    }
                }
                    break;
                case JTokenType.Array:
                {
                    var current = currentJson as JArray;
                    var model = modelJson as JArray;
                    var plus = new JArray(current!.Except(model!, new JTokenEqualityComparer()));
                    var minus = new JArray(model.Except(current, new JTokenEqualityComparer()));
                    if (plus.HasValues) diff["+"] = plus;
                    if (minus.HasValues) diff["-"] = minus;
                }
                    break;
                default:
                    diff["+"] = currentJson;
                    diff["-"] = modelJson;
                    break;
            }

            return diff;
        }
    }
}