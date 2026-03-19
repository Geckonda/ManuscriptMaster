package com.MM.ManuscriptMaster.mapper;

import com.MM.ManuscriptMaster.domain.model.Book;
import com.MM.ManuscriptMaster.domain.model.Episode;
import com.MM.ManuscriptMaster.dto.response.BookResponse;
import com.MM.ManuscriptMaster.dto.response.BookSimpleResponse;
import com.MM.ManuscriptMaster.dto.response.EpisodeSimpleResponse;
import org.springframework.stereotype.Component;
import lombok.RequiredArgsConstructor;

import java.util.List;
import java.util.stream.Collectors;

@Component
@RequiredArgsConstructor
public class BookMapper {
    
    private final UserMapper userMapper;
    private final GenreMapper genreMapper;
    private final EpisodeMapper episodeMapper;

    public BookResponse toDetailedResponse(Book book) {
        if (book == null) {
            return null;
        }
        return BookResponse.builder()
                .id(book.getId())
                .title(book.getTitle())
                .author(userMapper.toSimpleResponse(book.getAuthor()))
                .genre(genreMapper.toSimpleResponse(book.getGenre()))
                .rating(book.getRating())
                .status(book.getStatus())
                .modificator(book.getModificator())
                .episodes(mapEpisodes(book.getEpisodes()))
                .build();
    }

    public BookSimpleResponse toPreviewResponse(Book book) {
        if (book == null) {
            return null;
        }
        return BookSimpleResponse.builder()
                .id(book.getId())
                .title(book.getTitle())
                .rating(book.getRating())
                .status(book.getStatus())
                .modificator(book.getModificator())
                .build();
    }

    private List<EpisodeSimpleResponse> mapEpisodes(List<Episode> episodes) {
        if (episodes == null) {
            return null;
        }
        return episodes.stream()
                .map(episodeMapper::toSimpleResponse)
                .collect(Collectors.toList());
    }
}
