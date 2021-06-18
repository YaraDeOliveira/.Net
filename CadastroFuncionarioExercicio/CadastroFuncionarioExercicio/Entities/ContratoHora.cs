using System;


namespace CadastroFuncionarioExercicio.Entities
{
    public class ContratoHora
    {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoHora()
        {
        }

        public ContratoHora(DateTime date, double valorPorHora, int horas)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return (double) ValorPorHora * Horas;
        }

    }
}
