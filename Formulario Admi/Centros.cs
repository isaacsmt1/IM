using System;

namespace Formulario_Admi
{
    internal class Centros
    {
        private object text1;
        private object text2;

        public Centros(object text1, object text2)
        {
            this.text1 = text1;
            this.text2 = text2;
        }

        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}