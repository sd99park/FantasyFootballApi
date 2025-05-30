namespace FantasyFootballService.Helpers;

public static class GraphqlStrings
{
    public static string GET_DRAFTED_PLAYERS(string draftId)
    {
        return
            $"query get_draft {{" +
            $"    draftPicks: draft_picks(draft_id: \"{draftId}\") {{" +
            $"        draftId: draft_id" +
            $"        pickNumber: pick_no" +
            $"        sleeperId: player_id" +
            $"        pickedBy: picked_by" +
            $"        isKeeper: is_keeper" +
            $"    }}" +
            $"}}";
    }

    public static string GET_DRAFT_INFO(string draftId)
    {
        return $"query get_draft {{" +
               $"    draftInfo: get_draft(sport: \"nfl\" draft_id: \"{draftId}\") {{" +
               $"        draftId: draft_id" +
               $"        metaData: metadata" +
               $"    }}" +
               $"}}";
    }
}