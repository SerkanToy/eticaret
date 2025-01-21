namespace eticaret.Domain.Interfaced
{
    public interface IModel
    {
        string CreateBy { get; set; }
        string? ModifiedBy { get; set; }
        string? DeleteBy { get; set; }
        string CreateDate { get; set; }
        string? ModifiedDate { get; set; }
        string? DeleteDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
