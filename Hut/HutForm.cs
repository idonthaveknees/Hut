using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hut
{
    public partial class Hut : Form
    {
        private clsHut hutProperties = new clsHut();
        private int W, H, S, t;
        private PointF[] points;

        public Hut()
        {
            InitializeComponent(); 
            UpdateHutProperties();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            whiteboardPanel.Paint += WhiteboardPanel_Paint;
            linePanel.Paint += LinePanel_Paint;
            WNumeric.ValueChanged += NumericUpDown_ValueChanged;
            HNumeric.ValueChanged += NumericUpDown_ValueChanged;
            SNumeric.ValueChanged += NumericUpDown_ValueChanged;
            tNumeric.ValueChanged += NumericUpDown_ValueChanged;
            rotNumeric.ValueChanged += NumericUpDown_ValueChanged;
        }

        private void WhiteboardPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int scale = 2;
            W = (int)WNumeric.Value * scale;
            H = (int)HNumeric.Value * scale;
            S = (int)SNumeric.Value * scale;
            t = (int)tNumeric.Value * scale;

            // Find the starting point of the cross-section based on the centre of the white panel
            int startX = (whiteboardPanel.Width - (W + 2 * S - 2 * t)) / 2;
            int startY = (whiteboardPanel.Height - H) / 2;

            points = GeneratePoints(startX, startY);

            RotatePoints(points);

            g.DrawLines(Pens.Red, points);

            DrawDimensioning(g, startX, startY);

            DrawBoldLines(g);

            linePanel.Invalidate();
        }

        private void LinePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            List<clsSectionLine> sectionLines = new List<clsSectionLine>();

            if (points == null)
            {
                return;
            }

            for (int i = 0; i < points.Length - 1; i++)
            {
                sectionLines.Add(new clsSectionLine(i + 1, points[i], points[i + 1]));
            }

            float yPos = 10;
            foreach (var lineInfo in sectionLines)
            {
                string lineText = $"{lineInfo.Id}: Length = {lineInfo.Length} mm";
                g.DrawString(lineText, new Font("Arial", 8), Brushes.Black, 0, yPos);
                yPos += 20;
            }
        }

        private void LineCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            whiteboardPanel.Invalidate();
        }

        private PointF[] GeneratePoints(int startX, int startY) 
        {
             return new PointF[]
            {
                new PointF(startX, startY),
                new PointF(startX, startY + t),
                new PointF(startX + S - t, startY + t),
                new PointF(startX + S - t, startY + H),
                new PointF(startX + W + S - t, startY + H),
                new PointF(startX + W + S - t, startY + t),
                new PointF(startX + W + 2 * S - t * 2, startY + t),
                new PointF(startX + W + 2 * S - t * 2, startY),
                new PointF(startX + W + S - t * 2, startY),
                new PointF(startX + W + S - t * 2, startY + H - t),
                new PointF(startX + S, startY + H - t),
                new PointF(startX + S, startY),
                new PointF(startX, startY)
            };
        }

        private void RotatePoints(PointF[] points) 
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(-90 + hutProperties.Rot, new PointF(whiteboardPanel.Height / 2, whiteboardPanel.Width / 2));
            matrix.TransformPoints(points);
        }

        private void DrawDimensioning(Graphics g, int startX, int startY)
        {
            int offsetSmall = 5;
            int offsetMain = 20;

            using (Font font = new Font("Arial", 8))
            {
                // W dimensioning
                PointF[] WPoints = new PointF[]
                {
                    new PointF(startX + S - t, startY + H + offsetSmall),
                    new PointF(startX + S + W - t, startY + H + offsetSmall),
                    new PointF(startX + S - t, startY + H + offsetMain),
                    new PointF(startX + S + W - t, startY + H + offsetMain)
                };

                DrawDimensioningLines(g, WPoints);

                string WText = hutProperties.W.ToString();
                SizeF sizeW = g.MeasureString(WText, font);
                PointF WTextPosition = new PointF(startX + W / 2 + S - t, startY + H + offsetMain);

                // H dimensioning
                PointF[] HPoints = new PointF[]
                {
                    new PointF(startX - offsetSmall, startY),
                    new PointF(startX + S - t - offsetSmall, startY + H),
                    new PointF(startX - offsetMain, startY),
                    new PointF(startX - offsetMain, startY + H)
                };

                DrawDimensioningLines(g, HPoints);

                string HText = hutProperties.H.ToString();
                SizeF sizeH = g.MeasureString(HText, font);
                PointF HTextPosition = new PointF(startX - sizeH.Width, startY + H / 2);

                // S dimensioning
                PointF[] SPoints = new PointF[]
                {
                    new PointF(startX + W + S - 2 * t, startY - offsetSmall),
                    new PointF(startX + W + 2 * S - 2 * t, startY - offsetSmall),
                    new PointF(startX + W + S - 2 * t, startY - offsetMain),
                    new PointF(startX + W + 2 * S - 2 * t, startY - offsetMain)
                };

                DrawDimensioningLines(g, SPoints);

                string SText = hutProperties.S.ToString();
                SizeF sizeS = g.MeasureString(SText, font);
                PointF STextPosition = new PointF(startX + W + 1.5f * S - t * 2, startY - offsetMain); 

                // t dimensioning
                PointF[] tPoints = new PointF[]
                {
                    new PointF(startX + W + S - 2 * t, startY + H / 2),
                    new PointF(startX + W + S - t + offsetMain, startY + H / 2),
                    new PointF(startX + W + S - 2 * t, startY + H / 2),
                    new PointF(startX + W + S - t, startY + H / 2),
                };

                DrawDimensioningLines(g, tPoints);

                string tText = hutProperties.t.ToString();
                SizeF sizet = g.MeasureString(tText, font);
                PointF tTextPosition = new PointF(startX + W + S - t + offsetMain, startY + H / 2 - sizet.Height / 2);


                PointF[] dimensioningPoints = new PointF[]
                {
                    WTextPosition, HTextPosition, STextPosition, tTextPosition
                };

                RotatePoints(dimensioningPoints);

                DrawValues(g, dimensioningPoints, font);
            }
        }

        void DrawDimensioningLines(Graphics g, PointF[] points)
        {
            int tick = 3;

            RotatePoints(points);

            g.DrawLine(Pens.DarkGray, points[0], points[2]);
            g.DrawLine(Pens.DarkGray, points[1], points[3]);
            g.DrawLine(Pens.DarkGray, points[2], points[3]);

            DrawTick(g, points[2], tick);
            DrawTick(g, points[3], tick);
        }

        private void DrawTick(Graphics g, PointF point, float tickLength)
        {
            PointF[] tickPoints = new PointF[]
            {
                new PointF(point.X - tickLength, point.Y + tickLength),
                new PointF(point.X + tickLength, point.Y - tickLength),
            };

            g.DrawLines(Pens.DarkGray, tickPoints);
        }
        
        private void DrawValues(Graphics g, PointF[] dimensioningPoints, Font font)
        {
            for (int i = 0; i < dimensioningPoints.Length; i++)
            {
                PointF transformedPoint = dimensioningPoints[i]; 
                
                string dimensionText;
                switch (i)
                {
                    case 0:
                        dimensionText = hutProperties.W.ToString();
                        break;
                    case 1:
                        dimensionText = hutProperties.H.ToString();
                        break;
                    case 2:
                        dimensionText = hutProperties.S.ToString();
                        break;
                    default:
                        dimensionText = hutProperties.t.ToString();
                        break;
                }

                SizeF textSize = g.MeasureString(dimensionText, font);
                PointF textPosition = new PointF(transformedPoint.X - textSize.Width / 2, transformedPoint.Y - textSize.Height / 2);
                g.DrawString(dimensionText, font, Brushes.DarkGray, textPosition);
            }
        }
        
        private void DrawBoldLines(Graphics g)
        {
            float boldLineWidth = 3.0f; 

            Pen boldPen = new Pen(Color.Red, boldLineWidth);

            for (int i = 0; i < lineCheckbox.Items.Count; i++)
            {
                if (lineCheckbox.GetItemChecked(i))
                {
                    if (i < points.Length - 1)
                    {
                        g.DrawLine(boldPen, points[i], points[i + 1]);
                    }
                }
            }

            boldPen.Dispose();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateHutProperties();
            whiteboardPanel.Invalidate();
        }

        private void UpdateHutProperties()
        {
            hutProperties.W = (int)WNumeric.Value;
            hutProperties.H = (int)HNumeric.Value;
            hutProperties.S = (int)SNumeric.Value;
            hutProperties.t = (int)tNumeric.Value;
            hutProperties.Rot = (int)rotNumeric.Value;
        }
    }
}
