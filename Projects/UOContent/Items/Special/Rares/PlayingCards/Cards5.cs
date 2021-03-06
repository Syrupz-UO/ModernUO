namespace Server.Items
{
    public class DecoCards5 : Item
    {
        [Constructible]
        public DecoCards5() : base(0xE18)
        {
            Movable = true;
            Stackable = false;
        }

        public DecoCards5(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}
