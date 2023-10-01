namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
///implementado
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            { //implementado
                throw new InvalidOperationException("A capacidade da suite é insuficiente para a quantidade de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        { //implementado
            if (Hospedes != null)
            {
                return Hospedes.Count;
            }
            return 0;
        }

        public decimal CalcularValorDiaria()
        { //implementado
            if (Suite != null)
            {
                decimal valor = DiasReservados * Suite.ValorDiaria;

               
                if (DiasReservados >= 10)
                {
                    valor *= 0.9m;
                }

                return valor;
            }
            throw new InvalidOperationException("A suite não foi configurada para a reserva.");
        }
    }
}