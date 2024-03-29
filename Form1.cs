using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using API_Class;
using Newtonsoft.Json;

namespace GetRandomPixivPic
{
    public partial class Form1 : Form
    {
        //无窗体拖拽
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("Shell32.dll")]
        public static extern int ShellExecuteA(IntPtr hwnd, StringBuilder lpszOp, StringBuilder lpszFile, StringBuilder lpszParams, StringBuilder lpszDir, int FsShowCmd);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public Form1()
        {
            InitializeComponent();
            ComboBox_SafeLevel.SelectedIndex = 0;
            ComboBox_ExcludeAI.SelectedIndex = 0;
            ComboBox_PictureSize.SelectedIndex = 0;
        }
        private void Btn_GetPicture_Click(object? sender, EventArgs e)
        {
            Btn_GetPicture.Click -= Btn_GetPicture_Click;
            GetRandomPixivPic();
        }

        private async Task GetRandomPixivPic()
        {
            string PictureSizeTemp = ComboBox_PictureSize.Text;
            string PictureTagsTemp = textBox_Tags.Text;
            string PictureUIDOnlyTemp = ComboBox_PictureSize.Text;

            string ApiUrl = "https://api.lolicon.app/setu/v2/?";
            switch (PictureSizeTemp)
            {
                case "原图":
                    ApiUrl += "size=original&";
                    break;
                case "正常":
                    ApiUrl += "size=regular&";
                    break;
                case "小型":
                    ApiUrl += "size=small&";
                    break;
                case "预览":
                    ApiUrl += "size=thumb&";
                    break;
                case "迷你":
                    ApiUrl += "size=mini&";
                    break;
                default:
                    ApiUrl += "size=regular&";
                    break;
            }
            switch (ComboBox_SafeLevel.Text)
            {
                case "安全":
                    ApiUrl += "r18=0&";
                    break;
                case "危险":
                    ApiUrl += "r18=1&";
                    break;
                case "混合":
                    ApiUrl += "r18=2&";
                    break;
                default:
                    ApiUrl += "r18=0&";
                    break;
            }
            switch (ComboBox_ExcludeAI.Text)
            {
                case "排除":
                    ApiUrl += "excludeAI=true&";
                    break;
                case "包含":
                    ApiUrl += "excludeAI=false&";
                    break;
                default:
                    ApiUrl += "excludeAI=false&";
                    break;
            }
            if (textBox_UID.Text.Length > 0 && textBox_UID.Text != null)
            {
                ApiUrl += $"uid={textBox_UID.Text}&";
            }
            if (textBox_Tags.Text.Length > 0 && textBox_Tags.Text != null)
            {
                string[] Array = textBox_Tags.Text.Split(",");
                foreach (string str in Array)
                {
                    ApiUrl += $"tag={str}&";
                }
            }
            ApiUrl = ApiUrl.Remove(ApiUrl.Length - 1);
            ProcessBar_GetPic.Value = 50;
            API_Class.Root JsonData = GetJsonObject(await GetJsonResponseFromWebAPI(ApiUrl));
            if (JsonData.data.Count < 1)
            {
                Btn_GetPicture.Click += Btn_GetPicture_Click;
                ProcessBar_GetPic.Value = 0;
                textbox_Console.Text = "未获取到相关图片";
                return;
            }
            if (ComboBox_SafeLevel.Text == "安全")
            {
                foreach (string tag in JsonData.data[0].tags)
                {
                    if (tag == "R-18")
                    {
                        await GetRandomPixivPic();
                        return;
                    }
                }
            }

            string ImageUrl = String.Empty;
            switch (PictureSizeTemp)
            {
                case "原图":
                    ImageUrl = JsonData.data[0].urls.original;
                    break;
                case "正常":
                    ImageUrl = JsonData.data[0].urls.regular;
                    break;
                case "小型":
                    ImageUrl = JsonData.data[0].urls.small;
                    break;
                case "预览":
                    ImageUrl = JsonData.data[0].urls.thumb;
                    break;
                case "迷你":
                    ImageUrl = JsonData.data[0].urls.mini;
                    break;
                default:
                    ImageUrl = JsonData.data[0].urls.regular;
                    break;
            }
            try
            {
                ProcessBar_GetPic.Value = 90;
                Picture.stream = await GetPictureFromURL(ImageUrl);
                pictureBox1.Image = Image.FromStream(Picture.stream);
                Picture.data = JsonData.data[0];
                Picture.size = PictureSizeTemp;
            }
            catch (Exception ex)
            {
                Btn_GetPicture.Click += Btn_GetPicture_Click;
                ProcessBar_GetPic.Value = 0;
                textbox_Console.Text = $"获取图片时发生错误, 错误原因：{ex.Message}";
                return;
            }
            textbox_Console.Clear();
            textbox_Console.AppendText($"标题: {Picture.data.title}{Environment.NewLine}");
            textbox_Console.AppendText($"作者:{Picture.data.author}({Picture.data.uid}){Environment.NewLine}");
            textbox_Console.AppendText("标签: ");
            for (int i = 0; i < Picture.data.tags.Count; i++)
            {
                textbox_Console.AppendText($"{Picture.data.tags[i]}{(i == Picture.data.tags.Count - 1 ? "" : ", ")}");
            }
            ProcessBar_GetPic.Value = 100;
            Btn_GetPicture.Click += Btn_GetPicture_Click;
        }
        private async Task<string?> GetJsonResponseFromWebAPI(string url)
        {
            HttpClient client = new HttpClient();
            string? str = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                str = await response.Content.ReadAsStringAsync();
            }
            catch
            { }
            return str;
        }
        private API_Class.Root GetJsonObject(string json_serial)
        {
            API_Class.Root WebJson = JsonConvert.DeserializeObject<API_Class.Root>(json_serial);
            return WebJson;
        }
        private async Task<Stream> GetPictureFromURL(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            try
            {
                response = await client.GetAsync(url);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream stream = await response.Content.ReadAsStreamAsync();
                return stream;
            }
            else
            {
                throw new Exception($"HTTP Status Code {response.StatusCode}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shutdown_timer.Tick += Shutdown_Process;
            shutdown_timer.Start();
        }
        private void Shutdown_Process(object sender, EventArgs e)
        {
            if (Opacity >= 0.05)
            {
                Opacity -= 0.05;
            }
            else
            {
                Application.Exit();
            }
        }
        private void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void LinkClicked(object sender, EventArgs e)
        {
            if (Picture.data == null)
            {
                textbox_Console.Text = "未获取到图片数据！";
                return;
            }
            if (sender == Btn_OpenPicURL)
            {
                ShellExecuteA(IntPtr.Zero, new StringBuilder("open"), new StringBuilder($"https://www.pixiv.net/artworks/{Picture.data.pid}"), new StringBuilder(""), new StringBuilder(""), 0);
            }
            else if (sender == Btn_OpenAuthorURL)
            {
                ShellExecuteA(IntPtr.Zero, new StringBuilder("open"), new StringBuilder($"https://www.pixiv.net/users/{Picture.data.uid}"), new StringBuilder(""), new StringBuilder(""), 0);
            }
        }

        private void Btn_SavePicture_Click(object sender, EventArgs e)
        {
            if (Picture.stream == null || Picture.data == null)
            {
                textbox_Console.Text = "未获取到图片数据！";
                return;
            }
            if (textBox_SaveFolder.Text.Length < 1 || textBox_SaveFolder.Text == null)
            {
                textbox_Console.Text = "未选择要保存的路径！";
                return;
            }
            string FileDir = $@"{textBox_SaveFolder.Text}\{Picture.size}_{Picture.data.pid}.jpg";
            if (File.Exists(FileDir))
            {
                textbox_Console.Text = "当前图片已存在！";
                return;
            }
            using (FileStream stream = new FileStream(FileDir, FileMode.Create))
            {
                byte[] buf = new byte[64];
                int bytesRead;
                Picture.stream.Position = 0;
                try
                {
                    while ((bytesRead = Picture.stream.Read(buf, 0, buf.Length)) > 0)
                    {
                        stream.Write(buf, 0, bytesRead);
                    }
                    textbox_Console.Text = "图片保存成功！";
                }
                catch (Exception ex)
                {
                    textbox_Console.Text = $"图片保存失败！原因: {ex.Message}";
                }
            }
        }
        private void Btn_SelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
                return;
            textBox_SaveFolder.Text = folderBrowserDialog1.SelectedPath;
        }
        private void ComboBox_SafeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox_SafeLevel.Text)
            {
                case "安全":
                    Label_SafeLevel.ForeColor = Color.FromArgb(64, 255, 64);
                    break;
                case "危险":
                    Label_SafeLevel.ForeColor = Color.FromArgb(255, 64, 64);
                    break;
                case "混合":
                    Label_SafeLevel.ForeColor = Color.FromArgb(255, 255, 64);
                    break;
            }
        }
        class Picture
        {
            public static string size;
            public static Stream? stream;
            public static DataItem data { get; set; }
            public List<string> Tags;
        }
    }
}
