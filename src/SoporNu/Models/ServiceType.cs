namespace SoporNu.Models
{
    /// <summary>
    ///   ÅVS service types.
    /// </summary>
    public enum ServiceType
    {
        Unknown = 0,

        /// <summary>
        ///   The service of collecting and recycling paper packaging.
        /// </summary>
        PaperPackaging = RecyclingTypes.PaperPackaging,

        /// <summary>
        ///   The service of collecting and recycling plastic packaging.
        /// </summary>
        PlasticPackaging = RecyclingTypes.PlasticPackaging,

        /// <summary>
        ///   The service of collecting and recycling metal packaging.
        /// </summary>
        MetalPackaging = RecyclingTypes.MetalPackaging,

        /// <summary>
        ///   The service of collecting and recycling clear glass packaging, such as bottles and cans.
        /// </summary>
        GlassPackagingClear = RecyclingTypes.GlassPackagingClear,

        /// <summary>
        ///   The service of collecting and recycling colored glass packaging, such as bottles and cans.
        /// </summary>
        GlassPackagingColored = RecyclingTypes.GlassPackagingColored,

        /// <summary>
        ///   The service of collecting and recycling newspapers and other printed matter, such as magazines, catalogs, and flyers.
        /// </summary>
        NewspapersAndOtherPrintedMatter = RecyclingTypes.NewspapersAndOtherPrintedMatter,

        /// <summary>
        ///   The service of collecting and recycling batteries.
        /// </summary>
        Batteries = RecyclingTypes.Batteries,

        /// <summary>
        ///   The service of collecting textiles. Collected textiles are reused or recycled.
        /// </summary>
        Textile = RecyclingTypes.Textiles,

        /// <summary>
        ///   The service of cleaning.
        /// </summary>
        Cleaning = 9,

        /// <summary>
        ///   The service of snow removal.
        /// </summary>
        SnowRemoval = 10,
    }
}
