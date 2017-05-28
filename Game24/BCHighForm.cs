using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Game24
{
     
    public partial class BCHighForm : Form
    {

        public BCScene scene;

        public BCHighForm()
        {
            InitializeComponent();
            OpenList();
        }

        private void OpenList()
        {
            try
            {
                using (FileStream filestream = new FileStream("BCHighScore.hi", FileMode.Open))
                {

                    IFormatter formater = new BinaryFormatter();
                    scene = (BCScene)formater.Deserialize(filestream);

                    foreach (BCHigh b in scene.lista)
                        listBox1.Items.Add(b);
                }


            }
            catch (Exception ex)
            {
                scene = new BCScene();
            }
        }



        public void ElemAdd(BCHigh ta)
        {
            scene.lista.Add(ta);
            scene.lista=scene.lista.OrderBy(o => o.time).ToList();
            listBox1.Items.Clear();

            if (scene.lista.Count > 10)
                scene.lista = scene.lista.GetRange(0, 9);

            foreach (BCHigh h in scene.lista)
                listBox1.Items.Add(h);


        }

      

        private void BCHighForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (FileStream filestream = new FileStream("BCHighScore.hi", FileMode.Create))
            {
                IFormatter formater = new BinaryFormatter();
                formater.Serialize(filestream, scene);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scene.lista = new List<BCHigh>();
            listBox1.Items.Clear();
        }


    }
}
