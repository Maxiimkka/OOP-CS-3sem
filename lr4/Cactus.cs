﻿using lr4;
using System.Xml.Linq;

namespace lr4;
class Cactus : APlant, IPlant
{
    #region Properties

    public override DateTime WillBeRipen
    {
        get => WasPlanted.AddSeconds(5);
    }

    #endregion

    #region Constrs

    public Cactus(string Name) : base(Name)
    {
        this.Type = TypePlant.CACTUS;
        this.Name = Name;
    }

    #endregion

    #region Methods

    void IPlant.Plant()
    {
        this.WasPlanted = DateTime.Now;
        Console.WriteLine($"Plant {Name} was planted");
    }

    public override void Plant()
    {
        this.WasPlanted = DateTime.Now;
        Console.WriteLine($"Plant {Name} was planted at {WasPlanted}");
    }

    public bool IsGrow()
    {
        if (DateTime.Now > WillBeRipen)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void GetFruits()
    {
        if (this.IsGrow())
        {
            Console.WriteLine($"Plant {Name} is ripen");
        }
        else
        {
            Console.WriteLine($"Plant {Name} is not ripen");
        }
    }

    #endregion

    #region Override Methods

    public override string ToString() => $"{Type}: {Name}";

    #endregion
}
