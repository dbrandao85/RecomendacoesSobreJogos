using System.ComponentModel.Design;
using System.Net;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
            //Variáveis que definem os gêneros a serem buscados
            Boolean mmorpg = false;
            Boolean shooter = false;

            if (cbMmorpg.Checked)
            {
                mmorpg = true;
            }
            if (cbShooter.Checked)
            {
                shooter = true;
            }
            */

        }

        private void buscarJogo_Click(object sender, EventArgs e)
        {
            ReceberJogos();
        }

        private void gbGenero_Enter(object sender, EventArgs e)
        {
        }

        private void ReceberJogos()
        {
            try
            {
                //Verifica se algum genero foi selecionado
                if (gbGeneros.Controls.OfType<CheckBox>().Any(x => x.Checked))
                {
                    //Verifica as plataformas selecionadas
                    string plataforma = "";
                    if (cbPc.Checked && cbNavegador.Checked)
                    {
                        MessageBox.Show("Somente uma platafoma pode ser selecionada");
                    }
                    else if(cbPc.Checked)
                    {
                        plataforma = "&platform=pc";
                    }
                    else if(cbNavegador.Checked)
                    {
                        plataforma = "&platform=browser";
                    }
                    else
                    {
                        plataforma = "";
                    }

                    //Cria o link para o JSON
                    string link = "https://www.freetogame.com/api/filter?tag=" + CriarLink()+plataforma;

                   
                    /*
                    var webClient = new WebClient();
                    recebeJson = webClient.DownloadString(link+plataforma);
                    */

                    tbResultado.Text = link;
                }
                else
                {
                    tbResultado.Text = "";
                    MessageBox.Show("É necessário escolher ao menos um gênero");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CriarLink()
        {
            string link = "";
            try
            {
                if (cb2D.Checked)
                {
                    if (link == "")
                    {
                        link += "2d";
                    }
                    else
                    {
                        link += ".2d";
                    }
                }
                if (cb3d.Checked)
                {
                    if (link == "")
                    {
                        link += "3d";
                    }
                    else
                    {
                        link += ".3d";
                    }
                }
                if (cbAcao.Checked)
                {
                    if (link == "")
                    {
                        link += "action";
                    }
                    else
                    {
                        link += ".action";
                    }
                }
                if (cbAnime.Checked)
                {
                    if (link == "")
                    {
                        link += "anime";
                    }
                    else
                    {
                        link += ".anime";
                    }
                }
                if (cbArtesMarciais.Checked)
                {
                    if (link == "")
                    {
                        link += "martial-arts";
                    }
                    else
                    {
                        link += ".martial-arts";
                    }
                }
                if (cbAviao.Checked)
                {
                    if (link == "")
                    {
                        link += "flight";
                    }
                    else
                    {
                        link += ".flight";
                    }
                }
                if (cbBarco.Checked)
                {
                    if (link == "")
                    {
                        link += "sailing";
                    }
                    else
                    {
                        link += ".sailing";
                    }
                }
                if (cbBattleRoyale.Checked)
                {
                    if (link == "")
                    {
                        link += "battle-royale";
                    }
                    else
                    {
                        link += ".battle-royale";
                    }
                }
                if (cbCarta.Checked)
                {
                    if (link == "")
                    {
                        link += "card";
                    }
                    else
                    {
                        link += ".card";
                    }
                }
                if (cbCorrida.Checked)
                {
                    if (link == "")
                    {
                        link += "racing";
                    }
                    else
                    {
                        link += ".racing";
                    }
                }
                if (cbEspaco.Checked)
                {
                    if (link == "")
                    {
                        link += "space";
                    }
                    else
                    {
                        link += ".space";
                    }
                }
                if (cbEsportes.Checked)
                {
                    if (link == "")
                    {
                        link += "sports";
                    }
                    else
                    {
                        link += ".sports";
                    }
                }
                if (cbFantasia.Checked)
                {
                    if (link == "")
                    {
                        link += "fantasy";
                    }
                    else
                    {
                        link += ".fantasy";
                    }
                }

                return link;

            }catch (Exception ex)
            {
                return link;
                MessageBox.Show(ex.Message);
            }
        }
                /*
                 || ||  ||  ||  ||
                         ||  ||  ||  ||  ||
                         ||  ||  || cbLowSpec.Checked || cbLuta.Checked ||
                        cbMilitar.Checked || cbMmo.Checked || cbMmofps.Checked || cbMmorpg.Checked || cbMmorts.Checked ||
                        cbMmotps.Checked || cbMoba.Checked || cbMortePermanente.Checked || cbMundoAberto.Checked ||
                        cbPixelado.Checked || cbPlataforma.Checked || cbPrimeiraPessoa.Checked || cbPVP.Checked || cbPVP.Checked ||
                        cbRpgAcao.Checked || cbSandbox.Checked || cbScifi.Checked || cbShooter.Checked || cbSobrevivencia.Checked ||
                        cbSocial.Checked || cbStrategy.Checked || cbSuperHeroi.Checked || cbTanque.Checked || cbTerceiraPessoa.Checked ||
                        cbTerror.Checked || cbTopDown.Checked || cbTowerDefense.Checked || cbTurno.Checked || cbVoxel.Checked || cbZumbi.Checked
                */
    }
}