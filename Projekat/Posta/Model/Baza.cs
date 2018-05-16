﻿using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Posta.Model
{
    public class Baza
    {
        public static Baza bazaInstanca;
        public static Baza Instanca
        {
            get
            {
                return bazaInstanca ?? (bazaInstanca = new Baza());
            }
        }
        private Baza()
        {

        }
        List<Potrosaci> items = new List<Potrosaci>();

        IMobileServiceTable<Potrosaci> userTableObj = App.MobileService.GetTable<Potrosaci>();
        IMobileServiceTable<Uposlenici> userTableObjUposlenici = App.MobileService.GetTable<Uposlenici>();
        public void dodajPotrosaca(Potrosac p)
        {
            try
            {
                Potrosaci obj = new Potrosaci();
                obj.Ime = p.Ime;
                obj.Prezime = p.Prezime;
                obj.Adresa = p.Adresa;
                obj.Email = p.Email;
                obj.Jmbg = p.JMBG1;
                obj.BrojTelefona = p.BrojTelefona;
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog potrosaca.");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }
        public void dodajUposlenka(Uposlenik p)
        {
            try
            {
                Uposlenici obj = new Uposlenici();
                obj.Ime = p.Ime;
                obj.Prezime = p.Prezime;
                obj.Adresa = p.Adresa;
                obj.Email = p.Email;
                obj.Password = p.Password;
                obj.TipPosla = p.TipPosla;
                userTableObjUposlenici.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog uposlenika.");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }

        public Potrosac dajPotrosaca(string jmbg)
        {
            dajIzBaze(jmbg);
            Potrosac novi = new Potrosac();
            novi.Ime = items[0].Ime;
            novi.Prezime = items[0].Prezime;
            novi.Adresa = items[0].Adresa;
            novi.JMBG1 = items[0].Jmbg;
            novi.Email = items[0].Email;
            novi.BrojTelefona = items[0].BrojTelefona;
            return novi;
        }
        private async Task<int> dajIzBaze(String jmbg)
        {
            IMobileServiceTable<Potrosaci> userTableObj = App.MobileService.GetTable<Potrosaci>();
            items = await userTableObj.Where(i => i.Jmbg.Equals(jmbg)).ToListAsync();
            return 0;
        }
        public void obrisiPotrosaca(string jmbg)
        {
            Potrosac p = dajPotrosaca(jmbg);
            brisi(p.JMBG1);
        } 

        private async Task<int> brisi(string jmbg)
        {
            JObject jo = new JObject();
            jo.Add("Jmbg", jmbg);
            await userTableObj.DeleteAsync(jo);
            return 0;
        }
    }
}