using System;

namespace Taticas
{
    class RemoveAcentos
    {
        public static string removerAcentuacao(string palavra)
        {
            string palavraSemAcento = null;
            string caracterComAcento = "áàãâäéèêëíìîïóòõôöúùûüçáàãâÄéèêëíìîïóòõÖôúùûÜç,. ?&:/!;ºª%‘’()\"”“";
            string caracterSemAcento = "aaaaaeeeeiiiiooooouuuucAAAAAEEEEIIIIOOOOOUUUUC--------------------";

            if (!String.IsNullOrEmpty(palavra))
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (caracterComAcento.IndexOf(Convert.ToChar(palavra.Substring(i, 1))) >= 0)
                    {
                        int car = caracterComAcento.IndexOf(Convert.ToChar(palavra.Substring(i, 1)));
                        palavraSemAcento += caracterSemAcento.Substring(car, 1);
                    }
                    else
                    {
                        palavraSemAcento += palavra.Substring(i, 1);
                    }
                }

                string[] cEspeciais = { "#39", "---", "--", "'", "#", "\r\n", "\n", "\r" };

                for (int q = 0; q < cEspeciais.Length; q++)
                {
                    palavraSemAcento = palavraSemAcento.Replace(cEspeciais[q], "-");
                }

                for (int x = (cEspeciais.Length - 1); x > -1; x--)
                {
                    palavraSemAcento = palavraSemAcento.Replace(cEspeciais[x], "-");
                }

                palavraSemAcento = palavraSemAcento.Replace("+", "-").Replace(Environment.NewLine, "").TrimStart('-').TrimEnd('-').Replace("<i>", "-").Replace("<-i>", "-").Replace("<br>", "").Replace("--", "-");
            }
            else
            {
                palavraSemAcento = "indefinido";
            }

            return palavraSemAcento.ToLower();
        }   
    }
}
