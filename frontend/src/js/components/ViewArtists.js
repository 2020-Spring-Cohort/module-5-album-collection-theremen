export default function ViewArtists(artists) {
    console.log(artists)
    return `
   <div> <h3 id="artisttitle">Artists</h3> </div>

    <div id="view-artists">
        ${artists.map(artist => {
            return `
            <div class="artist">
                <article class="artists2">
                <h4 class="artist__name">${artist.name}</h4>
                <img src="./images/${artist.image}" alt="${artist.image}"></img>
                <div>${artist.hometown}</div>
                <button class="edit-artist__submit">Edit</button>
                <button class="delete-artist__submit">Delete</button>
                <input class="artist__id" type="hidden" value="${artist.artistId}">
                </article>
                
            </div>
            `
        }).join("")}
    </div>
        <h3>Add an artist by filling out the boxes below:</h3>
    <section class="add-artist">
           <input class="add-artist__artistName" type="text" placeholder="Add an Artist here">
           <input class="add-artist__artistImage" type="text" placeholder="Add the Artist Image here">
           <input class="add-artist__artistHometown" type="text" placeholder="Add the Artist Hometown here">
            </br>
           <button class="add-artist__submit">Add an Artist</button>
        </section>
    `
}