export default function ViewArtists(artists) {
    console.log(artists)
    return `
    <ul id="view-artists">
        ${artists.map(artist => {
            return `
            <li class="artist">
                <div class="artist__name">${artist.name}</div>
                ${artist.image}
                ${artist.hometown}
                <button class="edit-artist__submit">Edit</button>
                <button class="delete-artist__submit">Delete</button>
                <input class="artist__id" type="hidden" value="${artist.artistId}">
            </li>
            `
        }).join("")}
    </ul>

    <section class="add-artist">
            <input class="add-artist__artistName" type="text" placeholder="Add an Artist here">
            <input class="add-artist__artistImage" type="text" placeholder="Add the Artist Image here">
            <input class="add-artist__artistHometown" type="text" placeholder="Add the Artist Hometown here">
            <button class="add-artist__submit">Add an Artist</button>
        </section>
    `
}