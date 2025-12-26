using System.Drawing;
using System.Windows.Forms;


namespace Tyuiu.MuliavinIM.Sprint7.Project.V14
{
    partial class FormAnalysis_MIM
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonTable_MIM;
        private Button buttonAnalysis_MIM;
        private GroupBox groupBoxStatistics_MIM;
        private Label labelTotalRoutes_MIM;
        private Label labelMinTime_MIM;
        private Label labelMaxTime_MIM;
        private Label labelAvgTime_MIM;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalysis_MIM));
            buttonTable_MIM = new Button();
            buttonAnalysis_MIM = new Button();
            groupBoxStatistics_MIM = new GroupBox();
            labelTotalRoutes_MIM = new Label();
            labelMinTime_MIM = new Label();
            labelMaxTime_MIM = new Label();
            labelAvgTime_MIM = new Label();
            ChartRoutes_MIM = new OxyPlot.WindowsForms.PlotView();
            buttonHelp_MIM = new Button();
            toolTip_MIM = new ToolTip(components);
            groupBoxStatistics_MIM.SuspendLayout();
            SuspendLayout();

            buttonTable_MIM.FlatStyle = FlatStyle.Flat;
            buttonTable_MIM.Location = new Point(10, 10);
            buttonTable_MIM.Name = "buttonTable_MIM";
            buttonTable_MIM.Size = new Size(100, 35);
            buttonTable_MIM.TabIndex = 0;
            buttonTable_MIM.Text = "Таблица";
            toolTip_MIM.SetToolTip(buttonTable_MIM, "Открыть таблицу");
            buttonTable_MIM.UseVisualStyleBackColor = true;
            buttonTable_MIM.Click += buttonTable_MIM_Click;

            buttonAnalysis_MIM.Enabled = false;
            buttonAnalysis_MIM.FlatStyle = FlatStyle.Flat;
            buttonAnalysis_MIM.Location = new Point(120, 10);
            buttonAnalysis_MIM.Name = "buttonAnalysis_MIM";
            buttonAnalysis_MIM.Size = new Size(100, 35);
            buttonAnalysis_MIM.TabIndex = 1;
            buttonAnalysis_MIM.Text = "Анализ";
            buttonAnalysis_MIM.UseVisualStyleBackColor = true;

            groupBoxStatistics_MIM.Controls.Add(labelTotalRoutes_MIM);
            groupBoxStatistics_MIM.Controls.Add(labelMinTime_MIM);
            groupBoxStatistics_MIM.Controls.Add(labelMaxTime_MIM);
            groupBoxStatistics_MIM.Controls.Add(labelAvgTime_MIM);
            groupBoxStatistics_MIM.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxStatistics_MIM.Location = new Point(10, 100);
            groupBoxStatistics_MIM.Name = "groupBoxStatistics_MIM";
            groupBoxStatistics_MIM.Size = new Size(307, 253);
            groupBoxStatistics_MIM.TabIndex = 2;
            groupBoxStatistics_MIM.TabStop = false;
            groupBoxStatistics_MIM.Text = "Статистика маршрутов";

            labelTotalRoutes_MIM.AutoSize = true;
            labelTotalRoutes_MIM.Location = new Point(10, 44);
            labelTotalRoutes_MIM.Name = "labelTotalRoutes_MIM";
            labelTotalRoutes_MIM.Size = new Size(239, 20);
            labelTotalRoutes_MIM.TabIndex = 0;
            labelTotalRoutes_MIM.Text = "Общее количество маршрутов:";

            labelMinTime_MIM.AutoSize = true;
            labelMinTime_MIM.Location = new Point(10, 78);
            labelMinTime_MIM.Name = "labelMinTime_MIM";
            labelMinTime_MIM.Size = new Size(218, 20);
            labelMinTime_MIM.TabIndex = 1;
            labelMinTime_MIM.Text = "Минимальное время в пути:";

            labelMaxTime_MIM.AutoSize = true;
            labelMaxTime_MIM.Location = new Point(10, 111);
            labelMaxTime_MIM.Name = "labelMaxTime_MIM";
            labelMaxTime_MIM.Size = new Size(223, 20);
            labelMaxTime_MIM.TabIndex = 2;
            labelMaxTime_MIM.Text = "Максимальное время в пути:";

            labelAvgTime_MIM.AutoSize = true;
            labelAvgTime_MIM.Location = new Point(10, 145);
            labelAvgTime_MIM.Name = "labelAvgTime_MIM";
            labelAvgTime_MIM.Size = new Size(174, 20);
            labelAvgTime_MIM.TabIndex = 3;
            labelAvgTime_MIM.Text = "Среднее время в пути:";

            ChartRoutes_MIM.Location = new Point(389, 59);
            ChartRoutes_MIM.Name = "ChartRoutes_MIM";
            ChartRoutes_MIM.PanCursor = Cursors.Hand;
            ChartRoutes_MIM.Size = new Size(380, 280);
            ChartRoutes_MIM.TabIndex = 4;
            ChartRoutes_MIM.Text = "plotView1";
            toolTip_MIM.SetToolTip(ChartRoutes_MIM, "График");
            ChartRoutes_MIM.ZoomHorizontalCursor = Cursors.SizeWE;
            ChartRoutes_MIM.ZoomRectangleCursor = Cursors.SizeNWSE;
            ChartRoutes_MIM.ZoomVerticalCursor = Cursors.SizeNS;

            buttonHelp_MIM.FlatStyle = FlatStyle.Flat;
            buttonHelp_MIM.Image = (Image)resources.GetObject("buttonHelp_MIM.Image");
            buttonHelp_MIM.Location = new Point(721, 2);
            buttonHelp_MIM.Name = "buttonHelp_MIM";
            buttonHelp_MIM.Size = new Size(48, 43);
            buttonHelp_MIM.TabIndex = 10;
            toolTip_MIM.SetToolTip(buttonHelp_MIM, "Справка");
            buttonHelp_MIM.Click += buttonHelp_MIM_Click;

            toolTip_MIM.Popup += toolTip_MIM_Popup;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(781, 365);
            Controls.Add(buttonHelp_MIM);
            Controls.Add(ChartRoutes_MIM);
            Controls.Add(buttonTable_MIM);
            Controls.Add(buttonAnalysis_MIM);
            Controls.Add(groupBoxStatistics_MIM);
            Name = "FormAnalysis_MIM";
            Text = "Анализ данных — MIM (V14)";
            groupBoxStatistics_MIM.ResumeLayout(false);
            groupBoxStatistics_MIM.PerformLayout();
            ResumeLayout(false);
        }
        private OxyPlot.WindowsForms.PlotView ChartRoutes_MIM;
        private Button buttonHelp_MIM;
        private ToolTip toolTip_MIM;
    }
}
