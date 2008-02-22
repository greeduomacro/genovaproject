using System; 
using Server; 
using Server.Mobiles;

namespace Server.Items
{
	public class EscutcheonDeAriadne : MetalKiteShield
	{
		public override int LabelNumber{ get{ return 1077694; } } // Escutcheon de Ariadne

		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseEnergyResistance{ get{ return 1; } }

		[Constructable]
		public EscutcheonDeAriadne() : base()
		{
			LootType = LootType.Blessed;
			Hue = 0x8A5;

			ArmorAttributes.DurabilityBonus = 50;
			Attributes.ReflectPhysical = 5;
			Attributes.DefendChance = 5;
		}

		public EscutcheonDeAriadne( Serial serial ) : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}