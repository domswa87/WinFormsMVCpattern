using System;
using System.Windows.Forms;

namespace WinFormsMVC
{
    public class Controller
    {
        //DELEGAT
        public delegate void DelegatDS(string s);

        // MODELE
        public DragonModel DragonModel { get; set; }

        // WIDOKI
        public Form1 Form1 { get; set; }
        public Form2 Form2 { get; set; }

        // KONSTRUKTOR
        public Controller(Form1 f1, Form2 f2)
        {
            this.Form1 = f1;
            this.Form2 = f2;
        }

        // START
        public void StartController()
        {
            StworzModel();
            StworzDelegat();
            OdswiezWidoki();
            PokazWidokStartowy();
        }

      

        public void StworzModel()
        {
            DragonModel = new DragonModel();
            DragonModel.HP = 1000;

            // WYSYLAM MODEL DO FORM 1 I DO FORM 2
            Form1.DragonModel = DragonModel;
            Form2.DragonModel = DragonModel;
        }
       
        public void StworzDelegat()
        {
            // TWORZE DELEGATA
            DelegatDS delegatForm1 = new DelegatDS(ZmianaForm1);
            DelegatDS delegatForm2 = new DelegatDS(ZmianaForm2);

            // WYSYLAM DELEGATA DO FORM 1 I DO FORM 2
            Form1.Delegat = delegatForm1;
            Form2.Delegat = delegatForm2;

        }
        public void PokazWidokStartowy()
        {
            // Ten fragment kodu musialem skopiowac z klasy PROGRAM.CS, ten kod uruchamia widok
            // uruchom sobie pusty projekt WindowsForm to zobaczysz gdzie jest ten kod na poczatku
            Application.Run(Form1);
        }

        // INFORMACJA ZWROTNA Z FORM 1
        public void ZmianaForm1(string s)
        {
            if (s == "Atak mieczem")
            {
                DragonModel.HP = DragonModel.HP - 1;
            }

            if (s == "Pokaz Form2")
            {
                Form1.Hide();
                Form2.Show();
            }

            OdswiezWidoki();

        }

        // INFORMACJA ZWROTNA Z FORM 2
        public void ZmianaForm2(string s)
        {
            if (s == "Atak toporem")
            {
                DragonModel.HP = DragonModel.HP - 5;
            }

            if (s == "Pokaz Form1")
            {
                Form2.Hide();
                Form1.Show();
            }

            OdswiezWidoki();
        }

        private void OdswiezWidoki()
        {
            Form1.UpdateControls();
            Form2.UpdateControls();
        }
    }
}
