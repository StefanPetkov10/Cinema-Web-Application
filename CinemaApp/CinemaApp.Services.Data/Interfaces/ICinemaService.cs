﻿using CinemaApp.Web.ViewModels.Cinema;

namespace CinemaApp.Services.Data.Interfaces
{
    public interface ICinemaService
    {
        Task<IEnumerable<CinemaIndexViewModel>> IndexGetAllOrderedByLocationAsync();

        Task AddCinemaAsync(AddCinemaFormModel model);

        Task<CinemaDetailsViewModel?> GetCinemaDetailsByIdAsync(Guid id);

        Task<EditCinemaFormModel?> GetCinemaForByIdAsync(Guid id);

        Task<bool> EditCinemaAsync(EditCinemaFormModel model);

        Task<DeleteCinemaViewModel?> GetCinemaForDeleteByIdAsync(Guid id);

        Task<bool> SoftDeleteCinemaAsync(Guid id);
    }
}
