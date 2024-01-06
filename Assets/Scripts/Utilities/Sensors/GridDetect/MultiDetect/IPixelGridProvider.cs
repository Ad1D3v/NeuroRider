﻿
namespace NeuroRider.Sensors.Grid
{
    /// <summary>
    /// The <see cref="CR_GridSensor"/> requires a <see cref="PixelGrid"/>.
    /// The class that provides it should implement IPixelGridProvider.
    /// </summary>

    public interface IPixelGridProvider
    {
        PixelGrid GetPixelGrid();
    }
}