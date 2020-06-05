using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Video_Uploader
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkGray, 2);
            pen.DashPattern = new float[] {2, 2};
                e.Graphics.DrawRectangle(pen, 1, 1, panel1.Width - 2, panel1.Height - 2);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enter -= textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Text = "Введите название видео";
            textBox1.Enter += textBox1_Enter;
        }

        void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Enter -= textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Text = "Введите теги для видео";
            textBox2.Enter += textBox2_Enter;
        }

        void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Enter -= textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            textBox4.TextChanged += textBox4_TextChanged;
        }

        void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.DarkGray;
            textBox4.Text = "Введите описание видео";
            textBox4.Enter += textBox4_Enter;
        }

        void openFileButton1_Enter(object sender, EventArgs e)
        {

        }

        void openFileButton1_Leave(object sender, EventArgs e)
        {

        }

       
        void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        void panel1_DragLeave(object sender, EventArgs e)
        {

        }

        void panel1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label5);
            panel1.Controls.Add(clearButton1);
            panel1.Controls.Add(uploadButton1);
            
            label5.Visible = true;
            label5.Location = new Point(239, 52);

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            label5.Text = files[0].ToString();
        }

        void clearButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(openFileButton1);
        }

        void clearButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(openFileButton1);
        }

        void uploadButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cancelButton1);
            panel1.Controls.Add(progressBar1);
            try
            {
                Thread thead = new Thread(() =>
                {
                    Run().Wait();
                });
                thead.IsBackground = true;
                thead.Start();

            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = textBox1.Text;
            video.Snippet.Description = textBox4.Text;
            string[] tagSeo = Regex.Split(textBox2.Text, ",");
            video.Snippet.Tags = tagSeo;
            video.Snippet.CategoryId = "22"; // Подробнее https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "public"; // или "private" или "public"
            var filePath = label5.Text; // Путь к файлу.

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                await videosInsertRequest.UploadAsync();
            }
        }

        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        {
            
            switch (progress.Status)
            {
                case UploadStatus.Starting:
                    break;

                case UploadStatus.Uploading:

                    label5.Text = String.Format("{0} мб загружено.", progress.BytesSent / 1048576);;
                    break;

                case UploadStatus.Completed:
                    DialogResult dialog = MessageBox.Show("Загзузка успешно завершена.", "Чтобы вернуться в начало, нажмите ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        panel1.Controls.Clear();
                        panel1.Controls.Add(label1);
                        panel1.Controls.Add(label2);
                        panel1.Controls.Add(openFileButton1);
                    }
                    break;

                case UploadStatus.Failed:
                    label5.Text = String.Format("Обнаружена ошибка не позволяющая завершить загрузку.\n{0}", progress.Exception);
                    break;
            }
        }

        void videosInsertRequest_ResponseReceived(Video video)
        {
           label5.Text = string.Format("Видео: {0} успешно загружено.", video.Id);
        }

        void cancelButton1_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Нажав кнопку 'Да', вы прервете загрузку", "Вы уверены что хотите остановить загрузку?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
        if (result == DialogResult.Yes)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(label1);
                panel1.Controls.Add(label2);
                panel1.Controls.Add(openFileButton1);
            }
        }

        void openFileButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Выберете видео файл для загрузки на сервер";
            file.InitialDirectory = @"C:\";
            if (file.ShowDialog() == DialogResult.OK);
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(label5);
                panel1.Controls.Add(clearButton1);
                panel1.Controls.Add(uploadButton1);
                label5.Parent = panel1;
                label5.Visible = true;
                label5.Location = new Point(239, 52);
                label5.Text = file.FileName;
            }
        }

        void openfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Выберете видео файл для загрузки на сервер";
            file.InitialDirectory = @"C:\";
            if (file.ShowDialog() == DialogResult.OK) ;
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(label5);
                panel1.Controls.Add(clearButton1);
                panel1.Controls.Add(uploadButton1);
                label5.Parent = panel1;
                label5.Visible = true;
                label5.Location = new Point(239, 52);
                label5.Text = file.FileName;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Leave -= textBox4_Leave;
            textBox4.TextChanged -= textBox4_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Leave -= textBox1_Leave;
            textBox1.TextChanged -= textBox1_TextChanged;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Leave -= textBox2_Leave;
            textBox2.TextChanged -= textBox2_TextChanged;
        }
    }
}
