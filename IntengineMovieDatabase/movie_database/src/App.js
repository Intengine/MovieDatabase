import React, { Component } from 'react';
import './App.css';

class App extends Component {
  constructor(props) {
    super(props);
    console.log("This is my initializer");

    const movies = [
        {id: 0, title: "Avengers: Infinity War", overview: "Lorem ipsum dolor sit amet."},
        {id: 1, title: "The Avengers", overview: "Lorem ipsum dolor sit amet."}
    ]

    this.state = {rows: [
            <p key="1">This is my row 0</p>,
            <p key="2">This is my row 1</p>,
            <p key="3">This is my row 2</p>
        ]};

    var movieRows = [];
    movies.forEach((movie) => {
        console.log(movie.title);
        const movieRow = <table key={movie.id}>
            <tbody>
            <tr>
                <td><img alt="movie poster" src=""/></td>
                <td>{movie.title}</td>
            </tr>
            </tbody>
        </table>
        movieRows.push(movieRow);
    });

    this.state = {rows: movieRows};
  }

  render() {
    return (
      <div className="App">

        <table className="titleBar">
          <tbody>
          <tr>
              <td><img alt="app logo" width="100" src="logo.png"/></td>
              <td width="10"></td>
              <td><h1>Intengine Movie Database</h1></td>
          </tr>
          </tbody>
        </table>

          <input className="searchBar" placeholder="Wpisz nazwę filmu"></input>

          {this.state.rows}

      </div>
    );
  }
}

export default App;