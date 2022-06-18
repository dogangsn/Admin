using Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.App
{
    public class blMenu
    {
        public List<Menus> get_List_Menus()
        {
            List<Menus> _List_Menus = new List<Menus>();


            #region Genel

            _List_Menus.Add(new Data.Menus(10, "Genel", "Genel", "", "-Help", "Help", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Genel", "Güvenlik", "", "-Private Security", "-Private Security", "", "PrivateSecurity", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Genel", "Güvenlik", "", "-MD5 Security", "-MD5 Security", "", "MD5Security", "", new int[] { 1 }));

            #endregion

            #region MSP
            _List_Menus.Add(new Data.Menus(10, "MSP", "Müşteri", "", "-Help", "Help", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "MSP", "Licence", "", "-Licence Listesi", "-Licence Oluştur", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "MSP", "Licence", "", "-Licence Oluştur", "-Licence Oluştur", "", "frnLisansCreate", "", new int[] { 1 }));
            #endregion

            #region SIS

            _List_Menus.Add(new Data.Menus(10, "SIS", "SIS", "", "-Help", "Help", "", "Help", "", new int[] { 1 }));

            #endregion

            return _List_Menus;
        }
    }
}
