﻿namespace CinemaApp.Services.Data.Interfaces
{
    public interface IBaseService
    {
        bool IsGuidIdValid(string? id, ref Guid parsedGuidId);
    }
}
