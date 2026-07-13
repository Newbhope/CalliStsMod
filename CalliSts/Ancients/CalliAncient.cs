using BaseLib.Abstracts;
using BaseLib.Extensions;
using BaseLib.Utils;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Relics;

namespace CalliSts.Ancients;

public class CalliAncient : CustomAncientModel
{
    protected override OptionPools MakeOptionPools => new OptionPools(
        [
            AncientOption<Nunchaku>(),
            AncientOption<Lantern>(),
            AncientOption<ArtOfWar>(),
            AncientOption<IceCream>()
            //more relic options
        ]
    );
    
    public override bool IsValidForAct(ActModel act)
    {
        return act.ActNumber() == 1;
    }

    //ancient_node_[modID]-[ancientclassname].png
    //ancient_node_[modID]-[ancientclassname]_outline.png
    
    /**
    public override string? CustomMapIconPath
    {
        return "images/"
    }
    
    public override string? CustomMapIconOutlinePath { get; }
    
    public override string? CustomRunHistoryIconPath { get; }
    
    
    public override string? CustomRunHistoryIconOutlinePath  { get; }
    */
    

}