using System;
using System.Linq;
using System.Text;
using static System.String;

namespace WindowsFormsApp1.BO
{
    internal static class ExtensoesUtil
    {
        #region + String

        public static bool ENulaVazia(this string valor) => IsNullOrEmpty(valor.ToTrimOrEmpty());
        public static string ToTrimOrEmpty(this string valor) => IsNullOrEmpty(valor) ? Empty : valor.Trim();

        public static string LimparTelefone(this string valor, bool tirarZeroDDD = false)
        {
            if (!valor.ENulaVazia())
            {
                valor = valor.LimparNumero();
                if (tirarZeroDDD)
                {
                    if (valor.Length > 0)
                    {
                        if (valor[0].Equals('0'))
                            valor = valor.Substring(1, valor.Length - 1);
                    }
                }
            }

            return valor;

        }
        public static string LimparNumero(this string campo)
        {
            string temp = string.Empty;
            if (campo.ENulaVazia()) return string.Empty;
            try
            {
                var o = campo.ToArray();

                foreach (var caracter in o)
                {
                    if (Char.IsDigit(caracter))
                        temp += caracter;
                }

                return temp;
            }
            catch
            {
                throw;
            }
        }

        public static string FormatarMascara(this string valor, string mascara)
        {
            StringBuilder dado = new StringBuilder();
            // remove caracteres nao numericos
            foreach (char c in valor)
            {
                if (Char.IsNumber(c))
                    dado.Append(c);
            }
            int indMascara = mascara.Length;
            int indCampo = dado.Length;
            StringBuilder saida = new StringBuilder();
            if (indCampo > 0)
            {
                for (; indCampo > 0 && indMascara > 0;)
                {
                    if (mascara[--indMascara] == '#')
                        indCampo--;
                }
                indMascara = 0;

                for (; indMascara < mascara.Length; indMascara++)
                {
                    saida.Append((mascara[indMascara] == '#') ? dado[indCampo++] : mascara[indMascara]);
                }
            }
            return saida.ToString();
        }

        public static string ColocarMascaraTelefone_DDD(this string valor)
        {
            valor = valor.ToTrimOrEmpty().LimparTelefone();
            if (!valor.ENulaVazia())
            {
                if (valor.Length == 11)
                {
                    valor = FormatarMascara(valor, "(##) #####-####");
                }
                else
                {
                    if (valor.Length == 10)
                        valor = FormatarMascara(valor, "(##) ####-####");
                    else
                        valor = string.Empty;
                }
            }
            return valor;
        }

        #endregion

        #region + Inteiro

        public static Int32 ToInt32(this string valor) => valor.ENulaVazia() ? 0 : Convert.ToInt32(valor);
        public static short ToShort(this object valor)
        {
            if (valor == null || valor == DBNull.Value)
                return 0;
            else
                return Convert.ToInt16(valor);
        }

        #endregion

    }
}
