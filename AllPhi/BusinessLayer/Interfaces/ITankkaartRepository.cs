﻿using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ITankkaartRepository
    {
        void VoegTankkaartToe(TankKaart tankkaart);
        public bool BestaatTankkaartNummer(string kaartnr);
        bool BestaatTankkaart(int tankkaartId);
        void VerwijderTankkaart(TankKaart tankkaart);
        void UpdateTankkaart(TankKaart tankkaart);
        TankKaart GeefTankkaart(int tankkaartId);
        IReadOnlyList<TankKaart> ZoekTankkaarten(string? kaartNr, DateTime? geldigheidsdatum, string? pincode, string? naamBestuurder, Brandstoftype_tankkaart? brandstoftype, bool? geblokkeerd);
    }
}
