using System.Collections.Immutable;
using System.Configuration;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string titulo = "";
        string url = "";
        string imagem = "";
        string ram = "";
        string numRam = "0";
        string plataforma = "";
        bool plataformaPC;

        private void buscarJogo_Click(object sender, EventArgs e)
        {
            try
            {             

                //Não verifica RAM para jogos de Navegador
                if (plataformaPC || cbPc.Checked)
                {
                    VerificarRam();
                    if(numRam == "0")
                    {
                        numRam = "Não informada";
                    }
                    else
                    {
                        numRam += " GB";
                    }
                    tbResultado.Text = "Título: " + titulo + Environment.NewLine +
                                        "Link: " + url + Environment.NewLine +
                                        "RAM: " + numRam;
                    pbImagem.ImageLocation = imagem;
                }
                else if (plataformaPC == false || cbNavegador.Checked)
                {
                    ReceberJogos();
                    tbResultado.Text = "Título: " + titulo + Environment.NewLine +
                        "Link: " + url + Environment.NewLine +
                        "RAM: Não informada";
                    pbImagem.ImageLocation = imagem;
                }
                

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + Environment.NewLine + "RAM = " + numRam);
            }
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
                    var webClient = new WebClient();
                    string recebeJson = webClient.DownloadString(link);

                    if(recebeJson == "{\"status\":0,\"status_message\":\"No active giveaways available at the moment, please try again later.\"}")
                    {
                        MessageBox.Show("Não foi possível localizar nenhum jogo com esses parâmetros");
                    }
                    else
                    {
                        //Recebe a lista de jogos
                        var jogos = JsonConvert.DeserializeObject<DadosJogos[]>(recebeJson);

                        int tamanhoDaLista = jogos.Length-1;
                        Random numAleatorio = new Random();
                        int posicaoAleatoria = numAleatorio.Next(0, tamanhoDaLista);

                        //Verifica informações do jogo
                        VerificarJogo(jogos[posicaoAleatoria].Id);
                        titulo = jogos[posicaoAleatoria].Title;
                        imagem = jogos[posicaoAleatoria].Thumbnail;

                    }
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

        private void VerificarRam()
        {
            //Verifica se alguma RAM foi escolhida
            if (Int32.Parse(cbRam.Text) == 0)
            {
                ReceberJogos();
            }
            else
            {
                //Recebe jogos até a RAM ser menor que a escolhida
                do
                {
                    ReceberJogos();
                } while (Int32.Parse(numRam) > Int32.Parse(cbRam.Text));
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
                if (cbLowSpec.Checked)
                {
                    if (link == "")
                    {
                        link += "low-spec";
                    }
                    else
                    {
                        link += ".low-spec";
                    }
                }
                if (cbLuta.Checked)
                {
                    if (link == "")
                    {
                        link += "fighting";
                    }
                    else
                    {
                        link += ".fighting";
                    }
                }
                if (cbMilitar.Checked)
                {
                    if (link == "")
                    {
                        link += "military";
                    }
                    else
                    {
                        link += ".military";
                    }
                }
                if (cbMmo.Checked)
                {
                    if (link == "")
                    {
                        link += "mmo";
                    }
                    else
                    {
                        link += ".mmo";
                    }
                }
                if (cbMmofps.Checked)
                {
                    if (link == "")
                    {
                        link += "mmofps";
                    }
                    else
                    {
                        link += ".mmofps";
                    }
                }
                if (cbMmorpg.Checked)
                {
                    if (link == "")
                    {
                        link += "mmorpg";
                    }
                    else
                    {
                        link += ".mmorpg";
                    }
                }
                if (cbMmorts.Checked)
                {
                    if (link == "")
                    {
                        link += "mmorts";
                    }
                    else
                    {
                        link += ".mmorts";
                    }
                }
                if (cbMmotps.Checked)
                {
                    if (link == "")
                    {
                        link += "mmotps";
                    }
                    else
                    {
                        link += ".mmotps";
                    }
                }
                if (cbMoba.Checked)
                {
                    if (link == "")
                    {
                        link += "moba";
                    }
                    else
                    {
                        link += ".moba";
                    }
                }
                if (cbMortePermanente.Checked)
                {
                    if (link == "")
                    {
                        link += "permadeath";
                    }
                    else
                    {
                        link += ".permadeath";
                    }
                }
                if (cbMundoAberto.Checked)
                {
                    if (link == "")
                    {
                        link += "open-world";
                    }
                    else
                    {
                        link += ".open-world";
                    }
                }
                if (cbPixelado.Checked)
                {
                    if (link == "")
                    {
                        link += "pixel";
                    }
                    else
                    {
                        link += ".pixel";
                    }
                }
                if (cbPlataforma.Checked)
                {
                    if (link == "")
                    {
                        link += "side-scroller";
                    }
                    else
                    {
                        link += ".side-scroller";
                    }
                }
                if (cbPrimeiraPessoa.Checked)
                {
                    if (link == "")
                    {
                        link += "first-person";
                    }
                    else
                    {
                        link += ".first-person";
                    }
                }
                if (cbPVP.Checked)
                {
                    if (link == "")
                    {
                        link += "pvp";
                    }
                    else
                    {
                        link += ".pvp";
                    }
                }
                if (cbPVE.Checked)
                {
                    if (link == "")
                    {
                        link += "pve";
                    }
                    else
                    {
                        link += ".pve";
                    }
                }
                if (cbRpgAcao.Checked)
                {
                    if (link == "")
                    {
                        link += "action-rpg";
                    }
                    else
                    {
                        link += ".action-rpg";
                    }
                }
                if (cbSandbox.Checked)
                {
                    if (link == "")
                    {
                        link += "sandbox";
                    }
                    else
                    {
                        link += ".sandbox";
                    }
                }
                if (cbScifi.Checked)
                {
                    if (link == "")
                    {
                        link += "sci-fi";
                    }
                    else
                    {
                        link += ".sci-fi";
                    }
                }
                if (cbShooter.Checked)
                {
                    if (link == "")
                    {
                        link += "shooter";
                    }
                    else
                    {
                        link += ".shooter";
                    }
                }
                if (cbSobrevivencia.Checked)
                {
                    if (link == "")
                    {
                        link += "survival";
                    }
                    else
                    {
                        link += ".survival";
                    }
                }
                if (cbSocial.Checked)
                {
                    if (link == "")
                    {
                        link += "social";
                    }
                    else
                    {
                        link += ".social";
                    }
                }
                if (cbStrategy.Checked)
                {
                    if (link == "")
                    {
                        link += "strategy";
                    }
                    else
                    {
                        link += ".strategy";
                    }
                }
                if (cbSuperHeroi.Checked)
                {
                    if (link == "")
                    {
                        link += "superhero";
                    }
                    else
                    {
                        link += ".superhero";
                    }
                }
                if (cbTanque.Checked)
                {
                    if (link == "")
                    {
                        link += "tank";
                    }
                    else
                    {
                        link += ".tank";
                    }
                }
                if (cbTerceiraPessoa.Checked)
                {
                    if (link == "")
                    {
                        link += "third-Person";
                    }
                    else
                    {
                        link += ".third-Person";
                    }
                }
                if (cbTerror.Checked)
                {
                    if (link == "")
                    {
                        link += "horror";
                    }
                    else
                    {
                        link += ".horror";
                    }
                }
                if (cbTopDown.Checked)
                {
                    if (link == "")
                    {
                        link += "top-down";
                    }
                    else
                    {
                        link += ".top-down";
                    }
                }
                if (cbTowerDefense.Checked)
                {
                    if (link == "")
                    {
                        link += "tower-defense";
                    }
                    else
                    {
                        link += ".tower-defense";
                    }
                }
                if (cbTurno.Checked)
                {
                    if (link == "")
                    {
                        link += "turn-based";
                    }
                    else
                    {
                        link += ".turn-based";
                    }
                }
                if (cbVoxel.Checked)
                {
                    if (link == "")
                    {
                        link += "voxel";
                    }
                    else
                    {
                        link += ".voxel";
                    }
                }
                if (cbZumbi.Checked)
                {
                    if (link == "")
                    {
                        link += "zombie";
                    }
                    else
                    {
                        link += ".zombie";
                    }
                }

                return link;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return link;
            }
        }
        private void VerificarJogo(string id)
        {
            //Recebe JSON com informações do jogo escolhido
            string link = "https://www.freetogame.com/api/game?id=" + id;
            var webClient = new WebClient();
            string recebeJsonJogo = webClient.DownloadString(link);
            InformacoesDoJogo jogo = JsonConvert.DeserializeObject<InformacoesDoJogo>(recebeJsonJogo);
            url = jogo.Game_url;
            if (jogo.Platform == "Web Browser")
            {
                ram = "Não informada";
                plataformaPC = false;
            }
            else
            {
                ram = jogo.minimum_system_requirements.memory;
                if(ram != null)
                {
                    numRam = Regex.Match(ram, @"\d+").Value;
                    if(numRam == null || numRam == "")
                    {
                        numRam = "0";
                    }
                }
                else
                {
                    numRam = "0";
                }
                plataformaPC = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}