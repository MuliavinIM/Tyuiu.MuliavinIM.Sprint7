using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.MuliavinIM.Sprint7.Project.V14
{
    partial class FormMain_MIM
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonTable_MIM;
        private Button buttonAnalysis_MIM;
        private DataGridView dataGridViewRoutes_MIM;
        private Button buttonAddRoute_MIM;
        private Button buttonEditRoute_MIM;
        private Button buttonDeleteRoute_MIM;
        private Button buttonSaveData_MIM;
        private Button buttonLoadData_MIM;
        private GroupBox groupBoxSearch_MIM;
        private TextBox textBoxSearchRoute_MIM;
        private Button buttonSearch_MIM;
        private Button buttonResetSearch_MIM;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MIM));
            buttonTable_MIM = new Button();
            buttonAnalysis_MIM = new Button();
            dataGridViewRoutes_MIM = new DataGridView();
            buttonAddRoute_MIM = new Button();
            buttonEditRoute_MIM = new Button();
            buttonDeleteRoute_MIM = new Button();
            buttonSaveData_MIM = new Button();
            buttonLoadData_MIM = new Button();
            groupBoxSearch_MIM = new GroupBox();
            textBoxSearchRoute_MIM = new TextBox();
            buttonSearch_MIM = new Button();
            buttonResetSearch_MIM = new Button();
            buttonHelp_MIM = new Button();
            toolTipMIM = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_MIM).BeginInit();
            groupBoxSearch_MIM.SuspendLayout();
            SuspendLayout();

            buttonTable_MIM.Enabled = false;
            buttonTable_MIM.FlatStyle = FlatStyle.Flat;
            buttonTable_MIM.Location = new Point(10, 10);
            buttonTable_MIM.Name = "buttonTable_MIM";
            buttonTable_MIM.Size = new Size(120, 35);
            buttonTable_MIM.TabIndex = 0;
            buttonTable_MIM.Text = "Таблица";

            buttonAnalysis_MIM.FlatStyle = FlatStyle.Flat;
            buttonAnalysis_MIM.Location = new Point(140, 10);
            buttonAnalysis_MIM.Name = "buttonAnalysis_MIM";
            buttonAnalysis_MIM.Size = new Size(120, 35);
            buttonAnalysis_MIM.TabIndex = 1;
            buttonAnalysis_MIM.Text = "Анализ";
            toolTipMIM.SetToolTip(buttonAnalysis_MIM, "Открыть анализ");
            buttonAnalysis_MIM.Click += buttonAnalysis_MIM_Click;

            dataGridViewRoutes_MIM.AllowUserToAddRows = false;
            dataGridViewRoutes_MIM.AllowUserToDeleteRows = false;
            dataGridViewRoutes_MIM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoutes_MIM.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewRoutes_MIM.Location = new Point(10, 55);
            dataGridViewRoutes_MIM.MultiSelect = false;
            dataGridViewRoutes_MIM.Name = "dataGridViewRoutes_MIM";
            dataGridViewRoutes_MIM.ReadOnly = true;
            dataGridViewRoutes_MIM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoutes_MIM.Size = new Size(760, 230);
            dataGridViewRoutes_MIM.TabIndex = 2;

            buttonAddRoute_MIM.Image = (Image)resources.GetObject("buttonAddRoute_MIM.Image");
            buttonAddRoute_MIM.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddRoute_MIM.Location = new Point(8, 326);
            buttonAddRoute_MIM.Name = "buttonAddRoute_MIM";
            buttonAddRoute_MIM.Size = new Size(105, 40);
            buttonAddRoute_MIM.TabIndex = 3;
            buttonAddRoute_MIM.Text = "Добавить";
            buttonAddRoute_MIM.TextAlign = ContentAlignment.MiddleRight;
            toolTipMIM.SetToolTip(buttonAddRoute_MIM, "Добавить новую строку маршрута");
            buttonAddRoute_MIM.Click += buttonAddRoute_MIM_Click;

            buttonEditRoute_MIM.Image = (Image)resources.GetObject("buttonEditRoute_MIM.Image");
            buttonEditRoute_MIM.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditRoute_MIM.Location = new Point(119, 326);
            buttonEditRoute_MIM.Name = "buttonEditRoute_MIM";
            buttonEditRoute_MIM.Size = new Size(135, 40);
            buttonEditRoute_MIM.TabIndex = 4;
            buttonEditRoute_MIM.Text = "Редактировать";
            buttonEditRoute_MIM.TextAlign = ContentAlignment.MiddleRight;
            toolTipMIM.SetToolTip(buttonEditRoute_MIM, "Включить режим редактирования");
            buttonEditRoute_MIM.Click += buttonEditRoute_MIM_Click;

            buttonDeleteRoute_MIM.Image = (Image)resources.GetObject("buttonDeleteRoute_MIM.Image");
            buttonDeleteRoute_MIM.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteRoute_MIM.Location = new Point(260, 326);
            buttonDeleteRoute_MIM.Name = "buttonDeleteRoute_MIM";
            buttonDeleteRoute_MIM.Size = new Size(95, 40);
            buttonDeleteRoute_MIM.TabIndex = 5;
            buttonDeleteRoute_MIM.Text = "Удалить";
            buttonDeleteRoute_MIM.TextAlign = ContentAlignment.MiddleRight;
            toolTipMIM.SetToolTip(buttonDeleteRoute_MIM, "Удалить выбранный маршрут");
            buttonDeleteRoute_MIM.Click += buttonDeleteRoute_MIM_Click;

            buttonSaveData_MIM.Image = (Image)resources.GetObject("buttonSaveData_MIM.Image");
            buttonSaveData_MIM.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveData_MIM.Location = new Point(359, 326);
            buttonSaveData_MIM.Name = "buttonSaveData_MIM";
            buttonSaveData_MIM.Size = new Size(110, 40);
            buttonSaveData_MIM.TabIndex = 6;
            buttonSaveData_MIM.Text = "Сохранить";
            buttonSaveData_MIM.TextAlign = ContentAlignment.MiddleRight;
            toolTipMIM.SetToolTip(buttonSaveData_MIM, "Сохранить данные в CSV-файл");
            buttonSaveData_MIM.Click += buttonSaveData_MIM_Click;

            buttonLoadData_MIM.Image = (Image)resources.GetObject("buttonLoadData_MIM.Image");
            buttonLoadData_MIM.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLoadData_MIM.Location = new Point(474, 326);
            buttonLoadData_MIM.Name = "buttonLoadData_MIM";
            buttonLoadData_MIM.Size = new Size(110, 40);
            buttonLoadData_MIM.TabIndex = 7;
            buttonLoadData_MIM.Text = "Загрузить";
            buttonLoadData_MIM.TextAlign = ContentAlignment.MiddleRight;
            toolTipMIM.SetToolTip(buttonLoadData_MIM, "Загрузить данные из CSV-файла");
            buttonLoadData_MIM.Click += buttonLoadData_MIM_Click;

            groupBoxSearch_MIM.Controls.Add(textBoxSearchRoute_MIM);
            groupBoxSearch_MIM.Controls.Add(buttonSearch_MIM);
            groupBoxSearch_MIM.Controls.Add(buttonResetSearch_MIM);
            groupBoxSearch_MIM.Location = new Point(590, 290);
            groupBoxSearch_MIM.Name = "groupBoxSearch_MIM";
            groupBoxSearch_MIM.Size = new Size(180, 100);
            groupBoxSearch_MIM.TabIndex = 8;
            groupBoxSearch_MIM.TabStop = false;
            groupBoxSearch_MIM.Text = "Поиск по номеру";

            textBoxSearchRoute_MIM.Location = new Point(10, 22);
            textBoxSearchRoute_MIM.Name = "textBoxSearchRoute_MIM";
            textBoxSearchRoute_MIM.Size = new Size(160, 23);
            textBoxSearchRoute_MIM.TabIndex = 0;

            buttonSearch_MIM.Location = new Point(10, 55);
            buttonSearch_MIM.Name = "buttonSearch_MIM";
            buttonSearch_MIM.Size = new Size(75, 30);
            buttonSearch_MIM.TabIndex = 1;
            buttonSearch_MIM.Text = "Найти";
            toolTipMIM.SetToolTip(buttonSearch_MIM, "Найти номер маршрута");
            buttonSearch_MIM.Click += buttonSearch_MIM_Click;

            buttonResetSearch_MIM.Location = new Point(95, 55);
            buttonResetSearch_MIM.Name = "buttonResetSearch_MIM";
            buttonResetSearch_MIM.Size = new Size(75, 30);
            buttonResetSearch_MIM.TabIndex = 2;
            buttonResetSearch_MIM.Text = "Сброс";
            toolTipMIM.SetToolTip(buttonResetSearch_MIM, "Сбросить фильтр");
            buttonResetSearch_MIM.Click += buttonResetSearch_MIM_Click;

            buttonHelp_MIM.FlatStyle = FlatStyle.Flat;
            buttonHelp_MIM.Image = (Image)resources.GetObject("buttonHelp_MIM.Image");
            buttonHelp_MIM.Location = new Point(722, 6);
            buttonHelp_MIM.Name = "buttonHelp_MIM";
            buttonHelp_MIM.Size = new Size(48, 43);
            buttonHelp_MIM.TabIndex = 9;
            toolTipMIM.SetToolTip(buttonHelp_MIM, "Справка");
            buttonHelp_MIM.Click += buttonHelp_MIM_Click;

            toolTipMIM.Popup += toolTipMIM_Popup;
 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(784, 400);
            Controls.Add(buttonHelp_MIM);
            Controls.Add(buttonTable_MIM);
            Controls.Add(buttonAnalysis_MIM);
            Controls.Add(dataGridViewRoutes_MIM);
            Controls.Add(buttonAddRoute_MIM);
            Controls.Add(buttonEditRoute_MIM);
            Controls.Add(buttonDeleteRoute_MIM);
            Controls.Add(buttonSaveData_MIM);
            Controls.Add(buttonLoadData_MIM);
            Controls.Add(groupBoxSearch_MIM);
            Name = "FormMain_MIM";
            Text = "Городской транспорт — MIM (V14)";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_MIM).EndInit();
            groupBoxSearch_MIM.ResumeLayout(false);
            groupBoxSearch_MIM.PerformLayout();
            ResumeLayout(false);
        }
        private Button button1;
        private Button buttonHelp_MIM;
        private ToolTip toolTipMIM;
    }
}
