using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDatabaseApp
{
    public partial class GraphSelForm : Form
    {
        int[] arrBoolean = new int[6];
        public GraphSelForm()
        {
            InitializeComponent();

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            //if (checkedListBox1.CheckedItems.Count != 0)
            //{
            // If so, loop through all checked items and print results.  
            //string s = "";
            //int items = checkedListBox1.CheckedItems.Count;
                for (int x = 0; x < 6; x++)
            {
                //s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
                //if (checkedListBox1.CheckedItems[x])
                //MessageBox.Show(checkedListBox1.CheckedItems[x]);
                if (checkedListBox1.GetItemCheckState(x) == CheckState.Checked )
                    arrBoolean[x] = 1;
                else
                {
                    arrBoolean[x] = 0;
                }
            
                // s = s + arrBoolean[x].ToString();

                //MessageBox.Show(arrBoolean[x].ToString());
            }

          
                if (arrBoolean[0] == 1)
                {
                    Thumb_Graph_Form Thumb_graph = new Thumb_Graph_Form();
                    Thumb_graph.Show();
                }
                if (arrBoolean[1] == 1)
                {
                    ForeFootL ForeFootLGraph = new ForeFootL();
                    ForeFootLGraph.Show();
                }

                if (arrBoolean[2] == 1)
                {
                    ForeFootM ForeFootMGraph = new ForeFootM();
                    ForeFootMGraph.Show();
                }

                if (arrBoolean[3] == 1)
                {
                    ForeFootR ForeFootRGraph = new ForeFootR();
                    ForeFootRGraph.Show();
                }

                if (arrBoolean[4] == 1)
                {
                    Heel HeelGraph = new Heel();
                    HeelGraph.Show();
                }
                 if (arrBoolean[5] == 1)
                {
                
                    Graph_Form Graph_form = new Graph_Form();
                    Graph_form.Show();
                }


        }
    }
}
