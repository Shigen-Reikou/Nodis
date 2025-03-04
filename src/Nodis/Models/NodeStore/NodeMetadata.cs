﻿using VYaml.Annotations;

namespace Nodis.Models;

[YamlObject]
public partial class NodeMetadata
{
    [YamlMember("description")]
    public required string Description { get; set; }

    [YamlMember("icon")]
    public string? Icon { get; set; }

    [YamlMember("readme")]
    public string? Readme { get; set; }

    [YamlMember("homepage")]
    public string? Homepage { get; set; }

    [YamlMember("license")]
    public required string License { get; set; }

    [YamlMember("services")]
    public required IReadOnlyList<NodeRuntime> Runtimes { get; set; }

    [YamlMember("pre_install")]
    public IReadOnlyList<INodeInstallOperation> PreInstall { get; set; } = [];

    [YamlMember("post_install")]
    public IReadOnlyList<INodeInstallOperation> PostInstall { get; set; } = [];
}