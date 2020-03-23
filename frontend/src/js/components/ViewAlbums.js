export default function ViewAlbums(artist) {
    return `
    <ul id="view-albums">
        ${artist.albums.map(album => {
            return `
            <li class="album">
                <div class="album__name">${album.title}</div>
                ${album.image}
                ${album.recordLabel}
                <button class="edit-artist__submit">Edit</button>
                <button class="delete-artist__submit">Delete</button>
                <input class="artist__id" type="hidden" value="${album.albumId}">
            </li>
            `
        }).join("")}
    </ul>`
}