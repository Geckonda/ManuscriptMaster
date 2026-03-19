package com.MM.ManuscriptMaster.dto.response;

import com.MM.ManuscriptMaster.domain.model.BookModificator;
import com.MM.ManuscriptMaster.domain.model.BookRating;
import com.MM.ManuscriptMaster.domain.model.BookStatus;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class BookResponse {
    private Long id;
    private String title;
    private UserSimpleResponse author;
    private GenreSimpleResponse genre;
    private BookRating rating;
    private BookStatus status;
    private BookModificator modificator;
    private List<EpisodeSimpleResponse> episodes;
}
