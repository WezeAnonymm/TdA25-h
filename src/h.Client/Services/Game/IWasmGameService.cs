﻿using h.Contracts;
using h.Contracts.Components.Services;
using h.Contracts.Games;
using OneOf;

namespace h.Client.Services.Game;

public interface IWasmGameService : IWasmOnly
{
    Task<List<GameResponse>> LoadAllGamesAsync();
    Task<GameResponse?> LoadGameAsync(Guid gameId);
    Task DeleteGameAsync(Guid gameId);
    Task<OneOf<GameResponse, ErrorResponse>> UpdateGameAsync(UpdateGameRequest request);
    Task<OneOf<GameResponse, ErrorResponse>> CreateGameAsync(CreateNewGameRequest request);
}
