using SVSAP.Models;

namespace SVSAP.Content;

internal static class ModItemCatalog
{
    public const string UniqueId = "Koizumi.SVSAP";
    public const string Prefix = UniqueId + ".";

    public const string BasicCircuit = Prefix + "BasicCircuit";
    public const string AdvancedCircuit = Prefix + "AdvancedCircuit";
    public const string EliteCircuit = Prefix + "EliteCircuit";
    public const string NetworkCable = Prefix + "NetworkCable";
    public const string LinkTool = Prefix + "LinkTool";
    public const string BlankPattern = Prefix + "BlankPattern";
    public const string CraftingPattern = Prefix + "CraftingPattern";
    public const string ProcessingPattern = Prefix + "ProcessingPattern";
    public const string StorageCell1K = Prefix + "StorageCell1K";
    public const string StorageCell4K = Prefix + "StorageCell4K";
    public const string StorageCell64K = Prefix + "StorageCell64K";
    public const string StorageCell256K = Prefix + "StorageCell256K";
    public const string StorageCell1024K = Prefix + "StorageCell1024K";
    public const string StorageCell4096K = Prefix + "StorageCell4096K";
    public const string FilterCard = Prefix + "FilterCard";
    public const string CapacityCard = Prefix + "CapacityCard";
    public const string SpeedCard = Prefix + "SpeedCard";
    public const string QualityCard = Prefix + "QualityCard";
    public const string OreDictionaryCard = Prefix + "OreDictionaryCard";

    public const string NetworkCore = Prefix + "NetworkCore";
    public const string NetworkTerminal = Prefix + "NetworkTerminal";
    public const string CraftingTerminal = Prefix + "CraftingTerminal";
    public const string PatternTerminal = Prefix + "PatternTerminal";
    public const string StorageInterface = Prefix + "StorageInterface";
    public const string StorageDrive = Prefix + "StorageDrive";
    public const string Importer = Prefix + "Importer";
    public const string Exporter = Prefix + "Exporter";
    public const string MachineInterface = Prefix + "MachineInterface";
    public const string PatternProvider = Prefix + "PatternProvider";
    public const string MolecularAssembler = Prefix + "MolecularAssembler";
    public const string CraftingCpuCore = Prefix + "CraftingCpuCore";
    public const string CraftingMatrix1K = Prefix + "CraftingMatrix1K";
    public const string CraftingMatrix4K = Prefix + "CraftingMatrix4K";
    public const string CraftingMatrix16K = Prefix + "CraftingMatrix16K";
    public const string CraftingMatrix64K = Prefix + "CraftingMatrix64K";
    public const string CoProcessor = Prefix + "CoProcessor";
    public const string CraftingMonitor = Prefix + "CraftingMonitor";

    public static readonly IReadOnlyList<ObjectItemDefinition> ObjectItems = new List<ObjectItemDefinition>
    {
        new(BasicCircuit, "Basic Circuit", "基础电路", "早中期网络设备的核心元件。", 250, 336, -15, new[] { "item_material", "color_yellow" }),
        new(AdvancedCircuit, "Advanced Circuit", "进阶电路", "中后期网络设备和合成矩阵的核心元件。", 1200, 337, -15, new[] { "item_material", "color_purple" }),
        new(EliteCircuit, "Elite Circuit", "高级电路", "终局设备的核心元件。", 5000, 74, -15, new[] { "item_material", "color_prismatic" }),
        new(NetworkCable, "Network Cable", "网络线缆", "连接网络核心、终端和接口的线缆。", 20, 338, -15, new[] { "item_material", "color_gray" }),
        new(LinkTool, "Link Tool", "链接工具", "右键箱子或机器，将其绑定到指定网络。", 750, 787, -15, new[] { "item_tool", "color_blue" }),
        new(BlankPattern, "Blank Pattern", "空白样板", "用于编码合成样板或处理样板。", 50, 771, -15, new[] { "item_material", "color_white" }),
        new(CraftingPattern, "Crafting Pattern", "合成样板", "保存一条普通合成配方。", 100, 771, -15, new[] { "item_material", "pattern_item" }),
        new(ProcessingPattern, "Processing Pattern", "处理样板", "保存一条机器处理配方。", 100, 771, -15, new[] { "item_material", "pattern_item" }),
        new(StorageCell1K, "1K Item Storage Cell", "1K 物品存储元件", "SVSAP 字节存储元件，容量 1,024 字节，单一物品约 8,128 件。", 1000, 338, -15, new[] { "item_material", "storage_item" }),
        new(StorageCell4K, "4K Item Storage Cell", "4K 物品存储元件", "SVSAP 字节存储元件，容量 4,096 字节，单一物品约 32,704 件。", 4000, 337, -15, new[] { "item_material", "storage_item" }),
        new(StorageCell64K, "64K Item Storage Cell", "64K 物品存储元件", "SVSAP 字节存储元件，容量 65,536 字节，单一物品约 524,224 件。", 16000, 337, -15, new[] { "item_material", "storage_item" }),
        new(StorageCell256K, "256K Item Storage Cell", "256K 物品存储元件", "SVSAP 字节存储元件，容量 262,144 字节，单一物品约 2,097,088 件。", 40000, 337, -15, new[] { "item_material", "storage_item" }),
        new(StorageCell1024K, "1024K Item Storage Cell", "1024K 物品存储元件", "SVSAP 字节存储元件，容量 1,048,576 字节，单一物品约 8,388,544 件。", 120000, 337, -15, new[] { "item_material", "storage_item" }),
        new(StorageCell4096K, "4096K Item Storage Cell", "4096K 物品存储元件", "SVSAP 字节存储元件，容量 4,194,304 字节，单一物品约 33,554,368 件。", 400000, 74, -15, new[] { "item_material", "storage_item" }),
        new(FilterCard, "Filter Card", "物品过滤卡", "导入器和导出器的白名单/黑名单升级。", 150, 771, -15, new[] { "item_material", "upgrade_card" }),
        new(CapacityCard, "Capacity Card", "容量升级卡", "提高导入/导出每次处理数量。", 800, 336, -15, new[] { "item_material", "upgrade_card" }),
        new(SpeedCard, "Speed Card", "速度升级卡", "提高导入/导出频率。", 1200, 787, -15, new[] { "item_material", "upgrade_card" }),
        new(QualityCard, "Quality Card", "品质控制卡", "控制普通、银、金、铱品质优先级。", 1200, 72, -15, new[] { "item_material", "upgrade_card" }),
        new(OreDictionaryCard, "Ore Dictionary Card", "矿典卡", "让导入器和导出器按矿典/标签等价规则匹配过滤物品。", 1600, 771, -15, new[] { "item_material", "upgrade_card", "ore_dictionary_card" })
    };

    public static readonly IReadOnlyList<BigCraftableDefinition> BigCraftables = new List<BigCraftableDefinition>
    {
        new(NetworkCore, "Network Core", "网络核心", "网络的主控方块，保存 NetworkId 和成员关系。", 5000, 130),
        new(NetworkTerminal, "Network Terminal", "网络终端", "打开全网物品搜索与取放界面。", 1800, 129),
        new(CraftingTerminal, "Crafting Terminal", "合成终端", "从网络库存直接执行普通合成。", 2800, 129),
        new(PatternTerminal, "Pattern Terminal", "样板终端", "编码合成样板和处理样板。", 4200, 129),
        new(StorageInterface, "Storage Interface", "存储接口", "把旁边箱子作为网络物理库存。", 1000, 216),
        new(StorageDrive, "Storage Drive", "存储驱动器", "插入物品存储元件，提供数字化网络库存。", 2200, 130),
        new(Importer, "Importer", "导入器", "从旁边箱子或机器把物品吸入网络。", 1000, 105),
        new(Exporter, "Exporter", "导出器", "从网络输出指定物品到旁边箱子或机器。", 1000, 105),
        new(MachineInterface, "Machine Interface", "机器接口", "处理样板使用，把材料推给机器并收成品。", 3500, 105),
        new(PatternProvider, "Pattern Provider", "样板供应器", "持有样板并向机器接口发任务。", 4500, 130),
        new(MolecularAssembler, "Molecular Assembler", "分子装配器", "自动执行普通合成样板。", 5000, 130),
        new(CraftingCpuCore, "Crafting CPU Core", "合成 CPU 核心", "自动合成请求的主控，提供 1 个任务槽位。", 12000, 130),
        new(CraftingMatrix1K, "1K Crafting Matrix", "1K 合成矩阵", "小型自动合成任务容量。", 1600, 130),
        new(CraftingMatrix4K, "4K Crafting Matrix", "4K 合成矩阵", "中型自动合成任务容量。", 4800, 130),
        new(CraftingMatrix16K, "16K Crafting Matrix", "16K 合成矩阵", "大型自动合成任务容量。", 12000, 130),
        new(CraftingMatrix64K, "64K Crafting Matrix", "64K 合成矩阵", "终局自动合成任务容量。", 30000, 130),
        new(CoProcessor, "Co-Processor", "协处理器", "增加单个合成流程内的并行发派能力。", 7000, 130),
        new(CraftingMonitor, "Crafting Monitor", "合成监视器", "查看和取消自动合成任务。", 3500, 129)
    };

    public static readonly IReadOnlyDictionary<string, string> CraftingRecipes = new Dictionary<string, string>
    {
        [BasicCircuit] = "(O)338 3 (O)334 1 (O)335 1/Home/(O)" + BasicCircuit + " 1/false/null",
        [AdvancedCircuit] = "(O)" + BasicCircuit + " 2 (O)337 1 (O)72 1/Home/(O)" + AdvancedCircuit + " 1/false/null",
        [EliteCircuit] = "(O)" + AdvancedCircuit + " 2 (O)910 1 (O)74 1/Home/(O)" + EliteCircuit + " 1/false/null",
        [NetworkCable] = "(O)338 2 (O)334 1/Home/(O)" + NetworkCable + " 8/false/null",
        [LinkTool] = "(O)335 2 (O)338 3 (O)" + BasicCircuit + " 1 (O)" + NetworkCable + " 4/Home/(O)" + LinkTool + " 1/false/null",
        [BlankPattern] = "(O)388 5 (O)92 5 (O)338 1/Home/(O)" + BlankPattern + " 4/false/null",
        [StorageCell1K] = "(O)338 4 (O)334 1 (O)" + BasicCircuit + " 1/Home/(O)" + StorageCell1K + " 1/false/null",
        [StorageCell4K] = "(O)" + StorageCell1K + " 3 (O)336 1 (O)" + BasicCircuit + " 1/Home/(O)" + StorageCell4K + " 1/false/null",
        [StorageCell64K] = "(O)" + StorageCell4K + " 3 (O)337 1 (O)" + AdvancedCircuit + " 1/Home/(O)" + StorageCell64K + " 1/false/null",
        [StorageCell256K] = "(O)" + StorageCell64K + " 3 (O)787 2 (O)" + AdvancedCircuit + " 1/Home/(O)" + StorageCell256K + " 1/false/null",
        [StorageCell1024K] = "(O)" + StorageCell256K + " 3 (O)910 1 (O)" + EliteCircuit + " 1/Home/(O)" + StorageCell1024K + " 1/false/null",
        [StorageCell4096K] = "(O)" + StorageCell1024K + " 3 (O)" + EliteCircuit + " 2/Home/(O)" + StorageCell4096K + " 1/false/null",
        [FilterCard] = "(O)771 10 (O)338 2/Home/(O)" + FilterCard + " 1/false/null",
        [CapacityCard] = "(O)336 2 (O)338 5/Home/(O)" + CapacityCard + " 1/false/null",
        [SpeedCard] = "(O)787 1 (O)338 5/Home/(O)" + SpeedCard + " 1/false/null",
        [QualityCard] = "(O)72 1 (O)338 5/Home/(O)" + QualityCard + " 1/false/null",
        [OreDictionaryCard] = "(O)" + FilterCard + " 1 (O)337 1 (O)" + AdvancedCircuit + " 1/Home/(O)" + OreDictionaryCard + " 1/false/null",
        [NetworkCore] = "(O)390 60 (O)388 30 (O)378 20 (O)380 10 (O)335 2 (O)" + BasicCircuit + " 1/Home/(BC)" + NetworkCore + " 1/true/null",
        [NetworkTerminal] = "(O)390 30 (O)388 15 (O)334 1 (O)338 2 (O)" + BasicCircuit + " 1/Home/(BC)" + NetworkTerminal + " 1/true/null",
        [CraftingTerminal] = "(BC)" + NetworkTerminal + " 1 (BC)208 1 (O)787 1 (O)336 3 (O)338 10/Home/(BC)" + CraftingTerminal + " 1/true/null",
        [PatternTerminal] = "(BC)" + CraftingTerminal + " 1 (O)72 1 (O)337 1 (O)787 1/Home/(BC)" + PatternTerminal + " 1/true/null",
        [StorageInterface] = "(O)335 3 (O)338 5 (O)388 25/Home/(BC)" + StorageInterface + " 1/true/null",
        [StorageDrive] = "(O)390 80 (O)388 40 (O)335 3 (O)338 6 (O)" + BasicCircuit + " 1/Home/(BC)" + StorageDrive + " 1/true/null",
        [Importer] = "(O)335 5 (O)338 5/Home/(BC)" + Importer + " 1/true/null",
        [Exporter] = "(O)336 3 (O)335 2 (O)338 5/Home/(BC)" + Exporter + " 1/true/null",
        [MachineInterface] = "(O)337 1 (O)336 5 (O)" + BasicCircuit + " 1 (O)338 15/Home/(BC)" + MachineInterface + " 1/true/null",
        [PatternProvider] = "(O)337 2 (O)787 2 (O)" + BasicCircuit + " 1 (O)338 20/Home/(BC)" + PatternProvider + " 1/true/null",
        [MolecularAssembler] = "(O)337 2 (O)" + AdvancedCircuit + " 1 (O)338 20 (BC)208 1/Home/(BC)" + MolecularAssembler + " 1/true/null",
        [CraftingCpuCore] = "(O)337 3 (O)787 3 (O)" + AdvancedCircuit + " 2 (O)338 30/Home/(BC)" + CraftingCpuCore + " 1/true/null",
        [CraftingMatrix1K] = "(O)338 10 (O)335 3 (O)787 1 (O)" + BasicCircuit + " 1/Home/(BC)" + CraftingMatrix1K + " 1/true/null",
        [CraftingMatrix4K] = "(BC)" + CraftingMatrix1K + " 3 (O)336 3 (O)" + AdvancedCircuit + " 1/Home/(BC)" + CraftingMatrix4K + " 1/true/null",
        [CraftingMatrix16K] = "(BC)" + CraftingMatrix4K + " 3 (O)337 2 (O)" + AdvancedCircuit + " 1 (O)787 2/Home/(BC)" + CraftingMatrix16K + " 1/true/null",
        [CraftingMatrix64K] = "(BC)" + CraftingMatrix16K + " 3 (O)910 2 (O)" + EliteCircuit + " 1/Home/(BC)" + CraftingMatrix64K + " 1/true/null",
        [CoProcessor] = "(O)337 2 (O)787 2 (O)72 2 (O)" + AdvancedCircuit + " 1/Home/(BC)" + CoProcessor + " 1/true/null",
        [CraftingMonitor] = "(O)338 10 (O)336 2 (O)787 1 (O)" + BasicCircuit + " 1/Home/(BC)" + CraftingMonitor + " 1/true/null"
    };

    public static readonly IReadOnlyDictionary<string, int> CraftingRecipeMiningLevels = new Dictionary<string, int>
    {
        [BasicCircuit] = 1,
        [NetworkCable] = 1,
        [LinkTool] = 1,
        [BlankPattern] = 1,
        [StorageCell1K] = 1,
        [NetworkCore] = 1,
        [NetworkTerminal] = 1,
        [StorageInterface] = 1,
        [StorageDrive] = 1,
        [Importer] = 1,
        [Exporter] = 1,

        [AdvancedCircuit] = 3,
        [StorageCell4K] = 3,
        [StorageCell64K] = 3,
        [FilterCard] = 3,
        [CapacityCard] = 3,
        [SpeedCard] = 3,
        [QualityCard] = 3,
        [OreDictionaryCard] = 5,
        [CraftingTerminal] = 3,
        [CraftingCpuCore] = 3,
        [CraftingMatrix1K] = 3,
        [CraftingMatrix4K] = 3,
        [CraftingMonitor] = 3,

        [StorageCell256K] = 5,
        [PatternTerminal] = 5,
        [MachineInterface] = 5,
        [PatternProvider] = 5,
        [MolecularAssembler] = 5,
        [CraftingMatrix16K] = 5,
        [CoProcessor] = 5,

        [EliteCircuit] = 8,
        [StorageCell1024K] = 8,
        [StorageCell4096K] = 8,
        [CraftingMatrix64K] = 8
    };

    public static int GetRequiredMiningLevel(string recipeName)
    {
        return CraftingRecipeMiningLevels.TryGetValue(recipeName, out var level)
            ? level
            : 0;
    }

    public static string GetLocalKey(string itemId)
    {
        return itemId.StartsWith(Prefix, StringComparison.Ordinal)
            ? itemId[Prefix.Length..]
            : itemId;
    }

    public static bool IsNetworkEndpoint(string qualifiedItemId)
    {
        return BigCraftables.Any(item => qualifiedItemId == "(BC)" + item.Id);
    }

    public static bool TryGetStorageCellTier(string qualifiedItemId, out StorageCellTier tier)
    {
        tier = qualifiedItemId switch
        {
            "(O)" + StorageCell1K => StorageCellTier.OneK,
            "(O)" + StorageCell4K => StorageCellTier.FourK,
            "(O)" + StorageCell64K => StorageCellTier.SixtyFourK,
            "(O)" + StorageCell256K => StorageCellTier.TwoHundredFiftySixK,
            "(O)" + StorageCell1024K => StorageCellTier.OneThousandTwentyFourK,
            "(O)" + StorageCell4096K => StorageCellTier.FourThousandNinetySixK,
            _ => default
        };

        return tier is StorageCellTier.OneK
            or StorageCellTier.FourK
            or StorageCellTier.SixtyFourK
            or StorageCellTier.TwoHundredFiftySixK
            or StorageCellTier.OneThousandTwentyFourK
            or StorageCellTier.FourThousandNinetySixK;
    }
}

internal sealed record ObjectItemDefinition(
    string Id,
    string Name,
    string DisplayName,
    string Description,
    int Price,
    int SpriteIndex,
    int Category,
    IReadOnlyList<string> ContextTags);

internal sealed record BigCraftableDefinition(
    string Id,
    string Name,
    string DisplayName,
    string Description,
    int Price,
    int SpriteIndex);
