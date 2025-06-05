using System.Windows.Forms;

namespace WinFormsRistorante
{
    partial class FormAdmin
    {
        private DataGridView dgvDipendenti;
        private DataGridView dgvIngredienti;
        private TextBox txtNomeIngrediente;
        private TextBox txtQuantitaIngrediente;
        private Button btnAggiungiIngrediente;
        private Button btnApriCliente;
        private Button btnApriGestoreOrdini;

        private void InitializeComponent()
        {
            this.dgvDipendenti = new DataGridView();
            this.dgvIngredienti = new DataGridView();
            this.txtNomeIngrediente = new TextBox();
            this.txtQuantitaIngrediente = new TextBox();
            this.btnAggiungiIngrediente = new Button();
            this.btnApriCliente = new Button();
            this.btnApriGestoreOrdini = new Button();

            // 
            // dgvDipendenti
            // 
            this.dgvDipendenti.Location = new System.Drawing.Point(12, 12);
            this.dgvDipendenti.Size = new System.Drawing.Size(300, 150);

            // 
            // dgvIngredienti
            // 
            this.dgvIngredienti.Location = new System.Drawing.Point(330, 12);
            this.dgvIngredienti.Size = new System.Drawing.Size(300, 150);

            // 
            // txtNomeIngrediente
            // 
            this.txtNomeIngrediente.Location = new System.Drawing.Point(12, 180);
            this.txtNomeIngrediente.Size = new System.Drawing.Size(150, 23);
            this.txtNomeIngrediente.PlaceholderText = "Nome ingrediente";

            // 
            // txtQuantitaIngrediente
            // 
            this.txtQuantitaIngrediente.Location = new System.Drawing.Point(180, 180);
            this.txtQuantitaIngrediente.Size = new System.Drawing.Size(80, 23);
            this.txtQuantitaIngrediente.PlaceholderText = "Quantità";

            // 
            // btnAggiungiIngrediente
            // 
            this.btnAggiungiIngrediente.Location = new System.Drawing.Point(280, 180);
            this.btnAggiungiIngrediente.Size = new System.Drawing.Size(150, 23);
            this.btnAggiungiIngrediente.Text = "Aggiungi Ingrediente";
            this.btnAggiungiIngrediente.Click += new System.EventHandler(this.btnAggiungiIngrediente_Click);

            // 
            // btnApriCliente
            // 
            this.btnApriCliente.Location = new System.Drawing.Point(12, 230);
            this.btnApriCliente.Size = new System.Drawing.Size(100, 23);
            this.btnApriCliente.Text = "Apri Cliente";
            this.btnApriCliente.Click += new System.EventHandler(this.btnApriCliente_Click);

            // 
            // btnApriGestoreOrdini
            // 
            this.btnApriGestoreOrdini.Location = new System.Drawing.Point(130, 230);
            this.btnApriGestoreOrdini.Size = new System.Drawing.Size(130, 23);
            this.btnApriGestoreOrdini.Text = "Apri Gestore Ordini";
            this.btnApriGestoreOrdini.Click += new System.EventHandler(this.btnApriGestoreOrdini_Click);

            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(650, 280);
            this.Controls.Add(this.dgvDipendenti);
            this.Controls.Add(this.dgvIngredienti);
            this.Controls.Add(this.txtNomeIngrediente);
            this.Controls.Add(this.txtQuantitaIngrediente);
            this.Controls.Add(this.btnAggiungiIngrediente);
            this.Controls.Add(this.btnApriCliente);
            this.Controls.Add(this.btnApriGestoreOrdini);
            this.Text = "FormAdmin";
        }
    }
}
