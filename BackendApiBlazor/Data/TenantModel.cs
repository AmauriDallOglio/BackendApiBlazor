namespace BackendApiBlazor.Data
{
    public class TenantModel
    {
        public Guid Id { get; set; }
        public string Referencia { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public bool Inativo { get; set; }
        public Guid? Id_Imagem { get; set; }
    }


}
