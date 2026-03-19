package com.MM.ManuscriptMaster.dto.request;

import com.MM.ManuscriptMaster.domain.model.BookModificator;
import com.MM.ManuscriptMaster.domain.model.BookRating;
import com.MM.ManuscriptMaster.domain.model.BookStatus;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class BookUpdateRequest {
    private String title;
    private Long genreId;
    private BookRating rating;
    private BookStatus status;
    private BookModificator modificator;
}
