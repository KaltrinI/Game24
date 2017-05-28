using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Game24
{
    public partial class TAHighForm : Form
    {
        public TAScene scene;
        public TAHighForm()
        {
            InitializeComponent();
            OpenList();
        }


        private void OpenList()
        {
            try
            {
                using (FileStream filestream = new FileStream("TAHighScore.hi", FileMode.Open))
                {

                    IFormatter formater = new BinaryFormatter();
                    scene = (TAScene)formater.Deserialize(filestream);

                    foreach (TAHigh b in scene.lista)
                        listBox1.Items.Add(b);
                }


            }
            catch (Exception ex)
            {
                scene = new TAScene();
            }
        }


        public void ElemAdd(TAHigh ta)
        {
            scene.lista.Add(ta);
            scene.lista = scene.lista.OrderByDescending(o => o.correct).ToList();
            listBox1.Items.Clear();

            if (scene.lista.Count > 10)
                scene.lista = scene.lista.GetRange(0, 9);

            foreach (TAHigh h in scene.lista)
                listBox1.Items.Add(h);


        }

        private void TAHighForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (FileStream filestream = new FileStream("TAHighScore.hi", FileMode.Create))
            {
                IFormatter formater = new BinaryFormatter();
                formater.Serialize(filestream, scene);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scene.lista = new List<TAHigh>();
            listBox1.Items.Clear();
        }



    }
}
