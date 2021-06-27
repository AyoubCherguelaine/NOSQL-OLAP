using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace OLAPFinal
{
   public static class FormInsert   
    {

        public static void createButton(Button button, string name,string text, Size x, Point p, object mother,int tab)
        {
            button.Location = p;
            button.Name = name;
            button.Size = x;
            button.FlatStyle = FlatStyle.Flat;
            button.TabIndex = 0;
            button.Text = text;
            button.UseVisualStyleBackColor = true;
            ((Control)mother).Controls.Add(button);
        }

        public static  void createPanel(Panel panel, string name, Size x, Point p, object mother, int tab)
        {
            panel.Location = p;
            panel.Name = name;
            panel.Size = x;
            panel.TabIndex = 0;
           panel.ResumeLayout(false);
            ((Control)mother).Controls.Add(panel);

           
        }

        public static void createTextBox(TextBox textBox, string name, Size x, Point p, object mother, int tab)
        {
            textBox.Location = new System.Drawing.Point(381, 193);
            textBox.Name = name;
            textBox.Size = new System.Drawing.Size(100, 23);
            textBox.TabIndex = 0;
            ((Control)mother).Controls.Add(textBox);
        }

        public static void createLabel(Label label, string name, string text,Point p,object mother, int tab)
        {
            label.AutoSize = true;
            label.Location = p;
            label.Name = name;
            label.Text = text;
            label.TabIndex = tab;

           
        }
     
       
    
        public static void createCheckBox(CheckBox check,string name,string text,Size x,Point p, object mother,int tab)
        {
            check.AutoSize = true;
            check.Location = p;
            check.Name = name;
            check.Size = x;
            check.TabIndex = tab;
            check.Text = text;
            check.UseVisualStyleBackColor = true;
            ((Control)mother).Controls.Add(check);
        }
   
        public static void createRadioBox(RadioButton radio ,string name,Point p,string text,object mother,int tab)
        {
            radio.AutoSize = true;
            radio.Location = p;
            radio.Name = name;
        
            radio.TabIndex = tab;
            radio.TabStop = true;
            radio.Text =text;
            radio.UseVisualStyleBackColor = true;
            ((Control)mother).Controls.Add(radio);
        }
 
        public static void createPicture(PictureBox picture,string name,Point p,Size x,object mother,int tab)
        {
            picture.Location = p;
            picture.Name = name;
            picture.Size =x;
            picture.TabIndex = tab;
            picture.TabStop = false;
            ((Control)mother).Controls.Add(picture);

        }
   
        public static void createDataGridView(DataGridView view,string name,Point p,object mother,int tab)
        {
            view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view.Location = p;
            view.Name = name;
            view.AutoSize = true;
            view.TabIndex = tab;
            ((Control)mother).Controls.Add(view);
        }
    
        public static void createUserControl(object user,string name,Point p,object mother,int tab)
        {
            ((UserControl)user).TabIndex = tab;
            ((UserControl)user).Name = name;
            ((UserControl)user).Location = p;
            ((Control)mother).Controls.Add((UserControl)user);


        }

        public static void createListBox(ListBox list, string name,Size x, Point p , object mother,int tab)
        {
            list.FormattingEnabled = true;

            list.Size = x;
            list.Location = p;
            list.TabIndex = tab;
            list.Name = name;
            ((Control)mother).Controls.Add((ListBox)list);
        }

    }
}
