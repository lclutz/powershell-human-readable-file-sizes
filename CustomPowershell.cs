using System;

namespace CustomPowerShell
{
    public class Methods
    {
        const long KiB = 1024;
        const long MiB = KiB*1024;
        const long GiB = MiB*1024;
        const long TiB = GiB*1024;
        const long PiB = TiB*1024;

        public static string FormatFileSize(long Length)
        {
            switch (Length) {
                case >= PiB:
                    return String.Format("{0:0.#} PiB", Convert.ToSingle(Length) / Convert.ToSingle(PiB));
                case >= TiB:
                    return String.Format("{0:0.#} TiB", Convert.ToSingle(Length) / Convert.ToSingle(TiB));
                case >= GiB:
                    return String.Format("{0:0.#} GiB", Convert.ToSingle(Length) / Convert.ToSingle(GiB));
                case >= MiB:
                    return String.Format("{0:0.#} MiB", Convert.ToSingle(Length) / Convert.ToSingle(MiB));
                case >= KiB:
                    return String.Format("{0:0.#} KiB", Convert.ToSingle(Length) / Convert.ToSingle(KiB));
                case > 1:
                    return String.Format("{0} B  ", Length);
                default:
                    return "";
            }
        }
    }
}
