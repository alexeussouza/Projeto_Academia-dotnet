using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeStyle
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            Frm_Login login = new Frm_Login(this);
            login.ShowDialog();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if(Global.nivel >= 2)
                {

                    Frm_UsuarioNovo usuario = new Frm_UsuarioNovo();
                    abreForm(usuario, 2);
                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 2)
                {

                    Frm_UsuarioGestao usuarioGestao = new Frm_UsuarioGestao();
                    abreForm(usuarioGestao, 2);
                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void planosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void gestãoDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }
        private void gestãoDeTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {

                    Frm_Turmas turmas = new Frm_Turmas();

                    abreForm(turmas, 2);
                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void avaliaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {

                    Frm_Avaliacao av = new Frm_Avaliacao();
                    abreForm(av, 1);
                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void novoProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {

                    Frm_ProfessorNovo novoprof = new Frm_ProfessorNovo();
                    abreForm(novoprof, 1);

                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void gestãoDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {

                    Frm_ProfessoresGestão p = new Frm_ProfessoresGestão();
                    abreForm(p, 1);

                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }
        private void planosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {

                    Frm_AlunoNovo alunoNovo = new Frm_AlunoNovo();
                    abreForm(alunoNovo, 1);

                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 2)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 2)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                Frm_Sobre sobre = new Frm_Sobre();
                abreForm(sobre, 0);

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e) // logon do menu principal
        {
            Frm_Login login = new Frm_Login(this);
            login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e) // logoff do menu principal
        {
            lb_nivel.Text = "";
            lb_usuario.Text = "-----";
            pb_Logado.Image = Properties.Resources.Led_Vermelho;
            Global.logado = false;
        }

        private void abreForm(Form f, int nivel) // metodo generico para abrir formularios
        {
            if (Global.logado)
            {
                if(Global.nivel >= nivel)
                {
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Horario horario = new Frm_Horario();
            abreForm(horario, 2);
        }

        private void relatórioDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void relatórioDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }
        private void relatórioDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void relatorioDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }

        private void relatórioDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logado)
            {
                if (Global.nivel >= 1)
                {



                }
                else
                {
                    MessageBox.Show("Acesso Negado.");
                }

            }
            else
            {
                MessageBox.Show("Necessário ter usuário logado.");
            }
        }
    }
}
