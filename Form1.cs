//Leonard Jose Mendoza Hernandez CI 20060359

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Practica01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Thread caja;
        Thread tiempoa;
        Thread tiempoaA, tiempoaB, tiempoaC, tiempoaD;
        Thread tiempopA, tiempopB, tiempopC, tiempopD;


        int[] colacomida = new int[4];
        int[] cantcomida = new int[4];
        int[] limite = new int[4];
        int cp = 0;
        int total = 0;
        Random rdm = new Random();
        bool correr;
  
       

        


        private void Iniciar_Click(object sender, EventArgs e)
        {


           Control.CheckForIllegalCrossThreadCalls = false;
           caja = new Thread(run);
           tiempoa = new Thread(run2);
           tiempoaA = new Thread(runa);
           tiempoaB = new Thread(runb);
           tiempoaC = new Thread(runc);
           tiempoaD = new Thread(rund);
           tiempopA = new Thread(runap);
           tiempopB = new Thread(runbp);
           tiempopC = new Thread(runcp);
           tiempopD = new Thread(rundp);
      
           correr = true;




           
           caja.Start();
           tiempoa.Start();
           tiempoaA.Start();
           tiempoaB.Start();
           tiempoaC.Start();
           tiempoaD.Start();
           tiempopA.Start();
           tiempopB.Start();
           tiempopC.Start();
           tiempopD.Start();
           
            
           
          

        }



        public void run() {

          

            while (correr)
            {

                int frell = Int32.Parse(Frelleg.Value.ToString());

                Thread.Sleep(frell * 1000);

                
                cp++;

                person.Image = Image.FromFile("persona.png");
                

                CantPcaja.Text = "" + cp;
               

                


            }

          //  MessageBox.Show("Hilo terminado");
        
        }

        public void run2(){

            int rand;


           

                while (correr)
            {

                

                if (cp > 0)
                {
                    int tiat = Int32.Parse(TiempoAt.Value.ToString());

                    Thread.Sleep(tiat * 1000);

                    cp--;
                  
                    rand = rdm.Next(0,3);
               

                        colacomida[rand]++;

                       if(rand == 0)
                        personA.Image = Image.FromFile("persona.png");
                       if (rand == 1)
                           personB.Image = Image.FromFile("persona.png");
                       if (rand == 2)
                           personC.Image = Image.FromFile("persona.png");

                 if(cp ==0)
                     person.Image = null;


                }

                CantPA.Text = "" + colacomida[0];
                CantPB.Text = "" + colacomida[1];
                CantPC.Text = "" + colacomida[2];

                CantPcaja.Text = "" + cp;

             

                    
                

            }

          
        
        }


        public void runa() {

            while (correr) {

              


                if (colacomida[0] > 0 && cantcomida[0] > 0) {

                    int tiA = Int32.Parse(TAA.Value.ToString());

                    Thread.Sleep(tiA * 1000);
            
                    colacomida[0]--;
                    cantcomida[0]--;
                    colacomida[3]++;

                    if(colacomida[0] == 0)
                        personA.Image = null;

                    personD.Image = Image.FromFile("persona.png");

                }

                CantPA.Text = "" + colacomida[0];
                CantCA.Text = "" + cantcomida[0];
                CantPD.Text = "" + colacomida[3];

                
            }


        }


        public void runb() {

            while (correr)
            {

                if (colacomida[1] > 0 && cantcomida[1] > 0)
                {

                    int tiB = Int32.Parse(TAB.Value.ToString());

                    Thread.Sleep(tiB * 1000);

                    colacomida[1]--;
                    cantcomida[1]--;
                    colacomida[3]++;


                    if (colacomida[1] == 0)
                        personB.Image = null;

                    personD.Image = Image.FromFile("persona.png");

                }

                CantPB.Text = "" + colacomida[1];
                CantCB.Text = "" + cantcomida[1];
                CantPD.Text = "" + colacomida[3];

               

            }

            

        }


        public void runc() {

            while (correr)
            {

                if (colacomida[2] > 0 && cantcomida[2] > 0)
                {
                    int tiC = Int32.Parse(TAC.Value.ToString());

                    Thread.Sleep(tiC * 1000);

                    colacomida[2]--;
                    cantcomida[2]--;
                    colacomida[3]++;

                    if (colacomida[2] == 0)
                        personC.Image = null;

                    personD.Image = Image.FromFile("persona.png");
                }

                CantPC.Text = "" + colacomida[2];
                CantCC.Text = "" + cantcomida[2];
                CantPD.Text = "" + colacomida[3];


               

            }
        }


        public void rund() {
            
            while (correr) {

                if (colacomida[3] > 0 && cantcomida[3] > 0) {


                    int tiD = Int32.Parse(TAD.Value.ToString());
                    Thread.Sleep(tiD * 1000);
                    colacomida[3]--;
                    cantcomida[3]--;



                    if(cantcomida[3]==0)
                        personD.Image = null;

                    total++;
                    TT.Text = "" + total;

                
                }

                CantPD.Text = "" + colacomida[3];
                CantCD.Text = "" + cantcomida[3];


            
            
            }
        
        
        }

        public void runap()
        {
            
            while (correr)
            {

                int tipA = Int32.Parse(TPA.Value.ToString());

                Thread.Sleep(tipA * 1000);

              limite[0] = Int32.Parse(LPA.Value.ToString());

                if(cantcomida[0] < limite[0])
                cantcomida[0]++;

                

                CantCA.Text = "" + cantcomida[0];

                

            }

            
        }


        public void runbp()
        {

            while (correr)
            {

                int tipB = Int32.Parse(TPB.Value.ToString());

                Thread.Sleep(tipB * 1000);

                limite[1] = Int32.Parse(LPB.Value.ToString());
                if (cantcomida[1] < limite[1])
                    cantcomida[1]++;



                CantCB.Text = "" + cantcomida[1];

              


            }



        }


        public void runcp()
        {

            while (correr)
            {

                int tipC = Int32.Parse(TPC.Value.ToString());

                Thread.Sleep(tipC * 1000);


                limite[2] = Int32.Parse(LPC.Value.ToString());
                if (cantcomida[2] < limite[2])
                    cantcomida[2]++;



                CantCC.Text = "" + cantcomida[2];

               
            }
        }


        public void rundp() {

            while (correr)
            {


                int tipD = Int32.Parse(TPD.Value.ToString());

                Thread.Sleep(tipD * 1000);

                limite[3] = Int32.Parse(LPD.Value.ToString());
                if (cantcomida[3] < limite[3])
                    cantcomida[3]++;


                CantCD.Text = "" + cantcomida[3];

  
            
            
            }
        
        
        
        
        }



        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

          //  int frell = Int32.Parse(this.Frelleg.Value.ToString());
           
         //   textBox1.Text = frell.ToString(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
           
        }

        private void comA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            correr = false;



           MessageBox.Show("Realizado por Leonard Mendoza\nPuede cerrar la simulación");

          
           

        }


        private void reiniciar_Click_1(object sender, EventArgs e)
        {
            correr = false;
            colacomida = new int[] { 0, 0, 0, 0 };
            cantcomida = new int[] { 0, 0, 0, 0 };
            
            cp = 0;
            total = 0;

            CantPcaja.Text = "" + cp;
            CantPA.Text = "" + colacomida[0];
            CantPB.Text = "" + colacomida[1];
            CantPC.Text = "" + colacomida[2];
            CantPD.Text = "" + colacomida[3];
            CantCA.Text = "" + cantcomida[0];
            CantCB.Text = "" + cantcomida[1];
            CantCC.Text = "" + cantcomida[2];
            CantCD.Text = "" + cantcomida[3];
            TT.Text = "" + total;
            


        }

      
        
        
        }


    }

