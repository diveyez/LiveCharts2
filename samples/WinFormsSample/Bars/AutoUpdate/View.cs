﻿using LiveChartsCore.SkiaSharpView.WinForms;
using System.Windows.Forms;
using ViewModelsSamples.Bars.AutoUpdate;

namespace WinFormsSample.Bars.AutoUpdate
{
    public partial class View : UserControl
    {
        private readonly CartesianChart cartesianChart;

        public View()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(100, 100);

            var viewModel = new ViewModel();

            cartesianChart = new CartesianChart
            {
                Series = viewModel.Series,

                // out of livecharts properties...
                Location = new System.Drawing.Point(0, 50),
                Size = new System.Drawing.Size(100, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(cartesianChart);

            var b1 = new Button { Text = "Add item", Location = new System.Drawing.Point(0,0) };
            b1.Click += (object sender, System.EventArgs e) => viewModel.AddRandomItem();
            Controls.Add(b1);

            var b2 = new Button { Text = "Replace item", Location = new System.Drawing.Point(80, 0) };
            b2.Click += (object sender, System.EventArgs e) => viewModel.ReplaceRandomItem();
            Controls.Add(b2);

            var b3 = new Button { Text = "Remove item", Location = new System.Drawing.Point(160, 0) };
            b3.Click += (object sender, System.EventArgs e) => viewModel.RemoveFirstItem();
            Controls.Add(b3);

            var b4 = new Button { Text = "Add series", Location = new System.Drawing.Point(240, 0) };
            b4.Click += (object sender, System.EventArgs e) => viewModel.AddSeries();
            Controls.Add(b4);

            var b5 = new Button { Text = "Remove series", Location = new System.Drawing.Point(320, 0) };
            b5.Click += (object sender, System.EventArgs e) => viewModel.RemoveLastSeries();
            Controls.Add(b5);
        }

        private void B1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
