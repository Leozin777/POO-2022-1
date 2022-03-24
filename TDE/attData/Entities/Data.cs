using System;

namespace attData.Entities
{
    public class Data
    {
        int Dia;
        int Mes;
        int Ano;

        public Data(int dia, int mes, int ano)
        {
            setAno(ano);
            setMes(mes);
            setDia(dia);
            ExibirData();
        }

       public void setDia(int dia)
       {
           if(dia > 31 || dia < 1){
               MensagemErro(dia, "dia");
            }
            if(getMes() == 2 && dia > 28){
                MensagemErro(dia, "dia");
            }else {
                this.Dia = dia;
            }
        
       }
       public void setMes(int mes)
       {
           if(mes > 12){
               MensagemErro(mes, "mês");
           }else{
               this.Mes = mes;
           }
       }
       public void setAno(int ano)
       {
           if(ano < 0){
               MensagemErro(ano, " ano");
           }else{
               this.Ano = ano;
           }
           
       }

        public int getDia(){
            return this.Dia;
        }
        public int getMes(){
            return this.Mes;
        }

        public int getAno(){
            return this.Ano;
        }

        private void MensagemErro(int data, string tipo)
        {
            Console.WriteLine(data + " é um " + tipo + " inválido");
        }

        public void ExibirData(){
            if(getDia() != 0 && getMes() != 0 && getAno() != 0){
                Console.WriteLine(
                getDia() + "/" +
                getMes() + "/" +
                getAno()
                );
            }
        }

        
        
    }
}

