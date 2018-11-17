import React from 'react'

class MovieRow extends React.Component {
    viewMovie() {
        const url = "https://themoviedb.org/movie/" + this.props.movie.id;
        window.location.href = url;
    }

    viewTrailer() {
        const urlTrailer = "https://themoviedb.org/movie/" + this.props.movie.video;
        window.location.href = urlTrailer;
    }

    render() {
        return <table key={this.props.movie.id}>
            <tbody>
            <tr>
                <td><img alt="movie poster" width="150" src={this.props.movie.poster_src}/></td>
                <td width="10"></td>
                <td><h3>{this.props.movie.title}</h3>
                    <p>{this.props.movie.overview}</p>
                    <p>
                        <div className="c100 small dark rect-auto">
                            <span>{this.props.movie.vote_average}</span>
                            <div className="slice">
                                <div className="bar"></div>
                                <div className="fill"></div>
                            </div>
                        </div>
                        <input className="btn sixth" type="button" onClick={this.viewMovie.bind(this)} value="INFO"/>
                        <input className="btn seventh" type="button" onClick={this.viewTrailer.bind(this)} value="PLAY"/>
                    </p>
                </td>
            </tr>
            </tbody>
        </table>
    }
}

export default MovieRow;