namespace MyControls
{
    partial class QuickSearchCombobox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            //this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        #endregion
    }
}
