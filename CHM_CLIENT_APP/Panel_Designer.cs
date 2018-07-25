using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CHM_CLIENT_APP
{
    public class Place
    {
        public string _CODE;
        public int _height;
        public int _locationX;
        public int _locationY;
        public string _REF;
        public int _width;

        public Place(int locationX, int locationY, int width, int height, string CODE, string REF)
        {
            this._locationX = locationX;
            this._locationY = locationY;
            this._CODE = CODE;
            this._height = height;
            this._width = width;
            this._REF = REF;
        }

        public Place[] diviser_PANEL(int nb_bouton, int locX_panel, int locY_panel, int width_panel, int height_panel, int nb_categ, DataTable dt)
        {
            int nb_ligne = nb_categ;
            int nb_colonne = nb_bouton / nb_categ;
            if (nb_bouton > (nb_ligne * nb_colonne))
                nb_colonne += 1;
            Place[] BOUTONS = new Place[nb_colonne * nb_ligne];
            int largeur_place = width_panel / nb_colonne;
            int longueur_place = height_panel / nb_ligne;
            int locationX_courante = locX_panel;
            int locationY_courante = locY_panel;
            int btn = 0;
            for (int i = 0; i < nb_ligne; i++)
            {
                for (int j = 0; j < nb_colonne; j++)
                {

                    BOUTONS[btn] = new Place(locationX_courante, locationY_courante, largeur_place, longueur_place, "", "");

                    locationX_courante += largeur_place;
                    btn++;

                }
                locationY_courante += longueur_place;
                locationX_courante = locX_panel;
            }
            int h = 0;
            foreach (DataRow dr in dt.Rows)
            {
                BOUTONS[h]._CODE = dr["code"].ToString();
                BOUTONS[h]._REF = dr["ref"].ToString();
                h++;
            }
            return BOUTONS;
        }

    }
}
