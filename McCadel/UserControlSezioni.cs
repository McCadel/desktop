using ClassLibraryMcCadel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McCadel
{
    public partial class UserControlSezioni : UserControl
    {
        private Formhall sala;
        public UserControlSezioni(Formhall sala)
        {
            this.sala = sala;
            InitializeComponent();
            List<Sezione> menuCompleto = JsonSerializer.Deserialize<List<Sezione>>(
                File.ReadAllText("../../../menu.json"), 
                new JsonSerializerOptions { 
                    PropertyNameCaseInsensitive = true,
                    ReferenceHandler = ReferenceHandler.Preserve 
                }
            );


            Panel containerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(5)
            };

            this.Controls.Clear();
            this.Controls.Add(containerPanel);

            int y = 5;
            foreach (Sezione s in menuCompleto)
            {
                Panel sezione = new Panel
                {
                    Location = new Point(5, y),
                    Size = new Size(containerPanel.Width - 30, 50),
                    Margin = new Padding(3),
                    Padding = Padding.Empty,
                    Tag = s,
                    BackColor = Color.LightGray,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right
                    
                };

                Label scritta_sezione = new Label
                {
                    Text = s.Nome,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Margin = Padding.Empty,
                    Padding = Padding.Empty,
                };
                sezione.Click += (sender, e) => Click(s);
                containerPanel.Click += (sender, e) => Click(s);
                scritta_sezione.Click += (sender, e) => Click(s);
                sezione.Controls.Add(scritta_sezione);
                containerPanel.Controls.Add(sezione);

                y += 56;
            }

        }
        public void Click(Sezione s)
        {
            sala.UserControlMenu.CreateMenu(s);
        }
    }
}