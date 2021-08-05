using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace WiT_PluginSDK
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }
        void обSDKToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("WiT PluginSDK\nВерсия: " + Application.ProductVersion.Replace(".0", "") + "\nАвтор: Zalexanninev15", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        void MainForm_Load(object sender, EventArgs e) { if (Directory.Exists("out")) { Directory.Delete("out", true); } }
        void toolStripMenuItem1_Click(object sender, EventArgs e) { if (Directory.Exists("out")) { Directory.Delete("out", true); } listBox1.Items.Clear(); MessageBox.Show("Очистка завершена успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        void MainForm_FormClosed(object sender, FormClosedEventArgs e) { if (Directory.Exists("out")) { Directory.Delete("out", true); } }
        void купитьPremiumДляWiTToolStripMenuItem_Click(object sender, EventArgs e) { try { Process.Start("https://teletype.in/@zalexanninev15/buy"); } catch { MessageBox.Show("Браузер по умолчанию не найден, поэтому сслылка скопирована в буфер обмена!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); Clipboard.SetText("https://teletype.in/@zalexanninev15/buy"); } }
        void созданиеБиблиотекиПлагинаToolStripMenuItem_Click(object sender, EventArgs e) { try { Process.Start("https://teletype.in/@zalexanninev15/wit3_devplugin"); } catch { MessageBox.Show("Браузер по умолчанию не найден, поэтому сслылка скопирована в буфер обмена!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); Clipboard.SetText("https://teletype.in/@zalexanninev15/wit3_devplugin"); } }
        void toolStripMenuItem4_Click(object sender, EventArgs e) { Application.Restart(); }

        void упаковатьПлагинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("out"))
            {
                if (File.Exists(@Application.StartupPath + @"\out\core.wit3.plg.micro"))
                {
                    saveFile.FileName = "";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        if (PName.Text != "" && Version.Text != "" && API.Text != "" && Author.Text != "" && Help.Text != "" && CommandReg.Text != "")
                        {
                            if (File.Exists(saveFile.FileName)) { File.Delete(saveFile.FileName); }
                            System.Threading.Tasks.Task.Delay(100);
                            ZipFile.CreateFromDirectory("out", "plugin.wit");
                            File.Move("plugin.wit", saveFile.FileName);
                            MessageBox.Show("Плагин сохранён!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else { MessageBox.Show("Не найдены некоторые значения настроек проекта! Донастройте проект и сформируйте его заново!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else { MessageBox.Show("Не найдена библиотека плагина! Импортируйте её и сформируйте проект заново!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Перед сохранением необходимо сформировать проект!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void сформироватьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PName.Text != "" && Version.Text != "" && API.Text != "" && Author.Text != "" && Help.Text != "" && CommandReg.Text != "")
            {
                try { Directory.CreateDirectory("out"); } catch { }
                File.WriteAllText(@Application.StartupPath + @"\out\help.wit3.plg.micro", Help.Text);
                string about = "Название: " + PName.Text + "\nВерсия: " + Version.Text + "\nАвтор: " + Author.Text + "\nКоманда: " + CommandReg.Text;
                File.WriteAllText(@Application.StartupPath + @"\out\about.wit3.plg.micro", about);
                string cfg = "PluginAPI: " + API.SelectedItem + "\n!Отладка: " + debug.Checked.ToString().ToLower() + "\n!Простой вызов: " + ccControl.Checked.ToString().ToLower() + "\n!Включён: " + disChk.Checked.ToString().ToLower();
                File.WriteAllText(@Application.StartupPath + @"\out\core.config.wit3.plg.micro", cfg);
                try
                {
                    StreamWriter writer = new StreamWriter(@Application.StartupPath + @"\out\files.wit3.plg.micro");
                    foreach (var item in listBox1.Items) { writer.WriteLine(item.ToString()); }
                    writer.Close();
                }
                catch { }
                MessageBox.Show("Проект сформирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Не найдены некоторые значения настроек проекта! Донастройте проект и сформируйте его заново!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void button6_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("out"))
            {
                openFile.FileName = "";
                openFile.Filter = "Файл плагина| api.dll";
                openFile.Title = "Импортировать библиотеку плагина";
                openFile.Multiselect = false;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(@Application.StartupPath + @"\out\core.wit3.plg.micro")) { File.Delete(@Application.StartupPath + @"\out\core.wit3.plg.micro"); }
                    listBox1.Items.Remove("{Библиотека плагина}");
                    File.Copy(openFile.FileName, @Application.StartupPath + @"\out\core.wit3.plg.micro", true);
                    listBox1.Items.Add("{Библиотека плагина}");
                    MessageBox.Show("Библиотека плагина импортирована!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { MessageBox.Show("Перед импортом необходимо сформировать проект!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("out"))
            {
                if (File.Exists(@Application.StartupPath + @"\out\core.wit3.plg.micro"))
                {
                    openFile.FileName = "";
                    openFile.Filter = "Любые файлы|*.*";
                    openFile.Title = "Импортировать дополнительные файлы";
                    openFile.Multiselect = true;
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo FileNameI;
                        foreach (String file in openFile.FileNames)
                        {
                            FileNameI = new FileInfo(@file);
                            File.Copy(file, @Application.StartupPath + @"\out\" + FileNameI.Name, true);
                            try { listBox1.Items.Add(FileNameI.Name); } catch { }
                        }
                        MessageBox.Show("Дополнительные файлы импортированы!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("Перед импортом необходимо импортировать библиотеку плагина!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Перед импортом необходимо сформировать проект!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("out"))
            {
                try
                {
                    if (listBox1.SelectedItem.ToString() == "{Библиотека плагина}") { try { File.Delete(@Application.StartupPath + @"\out\core.wit3.plg.micro"); listBox1.Items.Remove("{Библиотека плагина}"); MessageBox.Show("Библиотека плагина удалена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch { } }
                    else { try { File.Delete(@Application.StartupPath + @"\out\" + listBox1.SelectedItem.ToString()); listBox1.Items.RemoveAt(listBox1.SelectedIndex); MessageBox.Show("Дополнительный файл удалён!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch { } }
                }
                catch { MessageBox.Show("Нет выбранного элемента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Перед удалением необходимо сформировать проект!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void button7_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("out"))
            {
                for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                {
                    if (listBox1.Items[i].ToString() == "{Библиотека плагина}")
                    {
                        try
                        {
                            File.Delete(@Application.StartupPath + @"\out\core.wit3.plg.micro");
                            listBox1.Items.Remove("{Библиотека плагина}");
                        }
                        catch { }
                    }
                    else
                    {
                        try
                        {
                            File.Delete(@Application.StartupPath + @"\out\" + listBox1.Items[i].ToString());
                            listBox1.Items.RemoveAt(i);
                        }
                        catch { }
                    }
                }
                MessageBox.Show("Все файлы удалены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Перед удалением необходимо сформировать проект!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.FileName = "";
                openFile.Filter = "Файл плагина WiT|*.wit";
                openFile.Title = "Открыть плагин";
                openFile.Multiselect = false;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try { Directory.Delete("out", true); } catch { }
                    ZipFile.ExtractToDirectory(openFile.FileName, @Application.StartupPath + @"\out\");
                    PluginReader();
                    MessageBox.Show("Плагин загружен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show("Данные плагина повреждены!\n" + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void PluginReader()
        {
            Help.Text = File.ReadAllText(@Application.StartupPath + @"\out\help.wit3.plg.micro");
            string[] line = File.ReadAllLines(@Application.StartupPath + @"\out\about.wit3.plg.micro");
            PName.Text = line[0].Replace("Название: ", "");
            Version.Text = line[1].Replace("Версия: ", "");
            Author.Text = line[2].Replace("Автор: ", "");
            CommandReg.Text = line[3].Replace("Команда: ", "");
            line = File.ReadAllLines(@Application.StartupPath + @"\out\core.config.wit3.plg.micro");
            API.SelectedItem = line[0].Replace("PluginAPI: ", "");
            debug.Checked = Convert.ToBoolean(line[1].Replace("!Отладка: ", ""));
            ccControl.Checked = Convert.ToBoolean(line[2].Replace("!Простой вызов: ", ""));
            listBox1.Items.Clear();
            line = File.ReadAllLines(@Application.StartupPath + @"\out\files.wit3.plg.micro");
            for (int i = 0; i < line.Length; i++) { listBox1.Items.Add(line[i]); }
        }
    }
}