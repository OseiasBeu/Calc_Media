using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDosAlunos
{

    class CalculoDaMedia
    {

        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        private double menorNota;
        private double maiorNota;
        private double media;
        public void CaculodaMedia()
        {
            limpar();

        }

        public void limpar()
        {
            this.nota1 = 0;
            this.nota2 = 0;
            this.nota3 = 0;
            this.nota4 = 0;
            this.menorNota = 0;
            this.maiorNota = 0;
            this.media = 0;
        }
        public void setNota1(double nota1)
        {
            this.nota1 = nota1;
        }
        public double getNota1()
        {
            return this.nota1;
        }

        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }
        public double getNota2()
        {
            return this.nota2;
        }
        public void setNota3(double nota3)
        {
            this.nota3 = nota3;
        }
        public double getNota3()
        {
            return this.nota3;
        }
        public void setNota4(double nota4)
        {
            this.nota4 = nota4;
        }
        public double getNota4()
        {
            return this.nota4;
        }

        public double getMenorNota()
        {
            return this.menorNota;
        }
        public double getMaiorNota()
        {
            return this.maiorNota;
        }
        public double getMedia()
        {
            return this.media;
        }
        private void calcularMedias()
        {
            this.media = (this.nota1 + this.nota2 + this.nota3 + this.nota4) / 4;
        }
        private void selecinaMaiorNota()
        {
            if(this.nota1 > this.nota2 && this.nota1 > this.nota3 && this.nota1 > this.nota4)
            {
                this.maiorNota = this.nota1;
            }else if(this.nota2 > this.nota1 && this.nota2 > this.nota3 && this.nota2 > this.nota4)
            {
                this.maiorNota = this.nota2;
            }else if(this.nota3 > this.nota1 && this.nota3 > this.nota2 && this.nota3 > this.nota4)
            {
                this.maiorNota = this.nota3;
            }else
            {
                this.maiorNota = this.nota4;
            }
        }
        private void selecionaMenorNota()
        {
            if (this.nota1 < this.nota2 && this.nota1 < this.nota3 && this.nota1 < this.nota4)
            {
                this.menorNota = this.nota1;
            }
            else if (this.nota2 < this.nota1 && this.nota2 < this.nota3 && this.nota2 < this.nota4)
            {
                this.menorNota = this.nota2;
            }
            else if (this.nota3 < this.nota1 && this.nota3 < this.nota2 && this.nota3 < this.nota4)
            {
                this.menorNota = this.nota3;
            }
            else
            {
                this.menorNota = this.nota4;
            }

    }

        public void fazerCalculoNotas()
        {
            selecinaMaiorNota();
            selecionaMenorNota();
            calcularMedias();
        }
    }
}

