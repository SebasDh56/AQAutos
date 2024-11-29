using Microsoft.EntityFrameworkCore;
using AQAPIAuto.Data;
using AQAPIAuto.Data.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace AQAPIAuto.Controllers;

public static class AQAutoEndpoints
{
    public static void MapAqautoEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Aqauto").WithTags(nameof(Aqauto));

        group.MapGet("/", async (AQAutosContext db) =>
        {
            return await db.Aqautos.ToListAsync();
        })
        .WithName("GetAllAqautos")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Aqauto>, NotFound>> (int aqautoid, AQAutosContext db) =>
        {
            return await db.Aqautos.AsNoTracking()
                .FirstOrDefaultAsync(model => model.AqautoId == aqautoid)
                is Aqauto model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetAqautoById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int aqautoid, Aqauto aqauto, AQAutosContext db) =>
        {
            var affected = await db.Aqautos
                .Where(model => model.AqautoId == aqautoid)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.AqautoId, aqauto.AqautoId)
                    .SetProperty(m => m.Aqmarca, aqauto.Aqmarca)
                    .SetProperty(m => m.Aqanio, aqauto.Aqanio)
                    .SetProperty(m => m.Aqcombustible, aqauto.Aqcombustible)
                    .SetProperty(m => m.Aqusado, aqauto.Aqusado)
                    .SetProperty(m => m.Aqprecio, aqauto.Aqprecio)
                    .SetProperty(m => m.AqEmaildistribuidor, aqauto.AqEmaildistribuidor)
                    .SetProperty(m => m.AqfechaIngreso, aqauto.AqfechaIngreso)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateAqauto")
        .WithOpenApi();

        group.MapPost("/", async (Aqauto aqauto, AQAutosContext db) =>
        {
            db.Aqautos.Add(aqauto);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Aqauto/{aqauto.AqautoId}",aqauto);
        })
        .WithName("CreateAqauto")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int aqautoid, AQAutosContext db) =>
        {
            var affected = await db.Aqautos
                .Where(model => model.AqautoId == aqautoid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteAqauto")
        .WithOpenApi();
    }
}
