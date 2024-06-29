namespace RoesteRentACar.Application.Features.CQRS.Queries.VehicleQueries
{
    public class GetVehicleByIdQuery
    {
        public GetVehicleByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
