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

                    //Recebe o link
                    string recebeJson = "https://www.freetogame.com/api/filter?tag=shooter"+plataforma;
                    /*
                    var webClient = new WebClient();
                    recebeJson = webClient.DownloadString("https://www.freetogame.com/api/filter?tag=shooter");
                    */
                    tbResultado.Text = recebeJson;
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
                /*
                cb2D.Checked || cb3d.Checked || cbAcao.Checked || cbAnime.Checked || cbArtesMarciais.Checked ||
                        cbAviao.Checked || cbBarco.Checked || cbBattleRoyale.Checked || cbCarta.Checked || cbCorrida.Checked ||
                        cbEspaco.Checked || cbEsportes.Checked || cbFantasia.Checked || cbLowSpec.Checked || cbLuta.Checked ||
                        cbMilitar.Checked || cbMmo.Checked || cbMmofps.Checked || cbMmorpg.Checked || cbMmorts.Checked ||
                        cbMmotps.Checked || cbMoba.Checked || cbMortePermanente.Checked || cbMundoAberto.Checked ||
                        cbPixelado.Checked || cbPlataforma.Checked || cbPrimeiraPessoa.Checked || cbPVP.Checked || cbPVP.Checked ||
                        cbRpgAcao.Checked || cbSandbox.Checked || cbScifi.Checked || cbShooter.Checked || cbSobrevivencia.Checked ||
                        cbSocial.Checked || cbStrategy.Checked || cbSuperHeroi.Checked || cbTanque.Checked || cbTerceiraPessoa.Checked ||
                        cbTerror.Checked || cbTopDown.Checked || cbTowerDefense.Checked || cbTurno.Checked || cbVoxel.Checked || cbZumbi.Checked
                */
    }
}