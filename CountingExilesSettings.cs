﻿using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using SharpDX;

namespace CountingExiles;

public class CountingExilesSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);
    
    public ToggleNode RenderGiganticSpawnPositions { get; set; } = new ToggleNode(true);
    public ColorNode GiganticSpawnColor { get; set; } = new ColorNode(Color.White);
    
    public ToggleNode RenderRitualRadius { get; set; } = new ToggleNode(true);
    public ColorNode RitualRadiusColor { get; set; } = new ColorNode(Color.Orange);
    public RangeNode<float> RitualRadius { get; set; } = new RangeNode<float>(1000f, 100f, 2000f);
    public RangeNode<int> RitualRadiusThickness { get; set; } = new RangeNode<int>(3, 1, 10);

    public ToggleNode RenderGiganticName { get; set; } = new ToggleNode(true);
}