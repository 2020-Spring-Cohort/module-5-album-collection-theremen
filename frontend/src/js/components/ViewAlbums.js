export default function ViewAlbums(artist) {
    return `
    <h3>${artist.name}</h3>
    <ul id="view-albums">
        ${artist.albums.map(album => {
            return `
            <li class="album">
                <h4 class="album__name">${album.title}</h4>
                <div>${album.image}</div>
                <div>${album.recordLabel}</div>
                <button class="edit-album__submit">Edit</button>
                <button class="delete-album__submit">Delete</button>
                <input class="album__id" type="hidden" value="${album.albumId}">
            </li>
            `
        }).join("")}
    </ul>
    <button class="view-artists">Go Back</button>`
}