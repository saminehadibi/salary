using Adibi.Debugging;

namespace Adibi
{
    public class AdibiConsts
    {
        public const string LocalizationSourceName = "Adibi";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ecaffb5e866644638292e93c9f8580d0";
    }
}
